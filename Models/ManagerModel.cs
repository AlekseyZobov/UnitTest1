using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Entities;
using Task3.ViewsModels;
using static Task3.Enums;

namespace Task3.Models
{
    public class ManagerModel
    {
        //Admixer3MContext mdb

        private MasterDbContext MDB { get; set; }
        public ManagerModel(MasterDbContext mdb)
        {
            MDB = mdb;
        }
        public VmAccountManager AddManager(VmAccountManager src, Guid SubsOId, Guid UserOId)
        {
            try
            {

                if (string.IsNullOrEmpty(src.Name))
                    throw new Exception("Empty name");

                if (string.IsNullOrEmpty(src.Pwd))
                    throw new Exception("Empty password");

                if (!Enum.IsDefined(typeof(EnumMasterRoleType), src.RoleType))
                    throw new Exception("Wrong role type");

                if (string.IsNullOrEmpty(src.Email))
                    throw new Exception("Empty email");



                var sub = MDB.Subscription
                     .Include("Roles.User")
                     .Include("Account")
                     .FirstOrDefault(x => x.OId == SubsOId);

                if (sub == null)
                {
                    throw new Exception("No access");
                }
                var currentUser = sub.Roles.FirstOrDefault(x => x.User.OId == UserOId);

                if (currentUser.RoleType != EnumMasterRoleType.Admin && currentUser.RoleType != EnumMasterRoleType.TradeDeskFullAcces)
                {
                    throw new Exception("No access");
                }
                var emailExist = MDB.User.Any(x => x.State != -1 && x.Email.ToLower() == src.Email.ToLower());
                if (emailExist)
                {
                    throw new Exception("Current email already used");
                }

                var user = new User() { State = 1, Account = sub.Account };
                MDB.User.Add(user);

                user.Name = src.Name;
                user.Email = src.Email;
                user.Password = src.Pwd;
                MDB.SaveChanges();

                var subType = sub.Type;
                switch (subType)
                {
                    case EnumSubscriptionType.Network:
                        {
                            src.RoleType = EnumMasterRoleType.NetworkOperator;
                        }; break;
                    case EnumSubscriptionType.AdmixerAdX:
                        {
                            src.RoleType = EnumMasterRoleType.Manager;
                        };
                        break;
                    case EnumSubscriptionType.AdmixerDSP:
                    case EnumSubscriptionType.NetworkAdvertiser:
                    case EnumSubscriptionType.TradeDesk:
                        {
                            src.RoleType = EnumMasterRoleType.Manager;
                        }; break;
                    case EnumSubscriptionType.Master:
                        src.RoleType = EnumMasterRoleType.Manager;
                        break;

                }

                var role = new Role() { Subscription = sub, User = user, State = 1, SubscriptionOId = sub.OId, RoleType = src.RoleType };
                MDB.Role.Add(role);
                MDB.SaveChanges();
                src.Id = user.Id;
                return src;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
