using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task3.Enums;

namespace Task3.Entities
{
    public class Role : EntityBase
    {
        public Role() { }
        public EnumMasterRoleType RoleType { get; set; }

        public Guid SubscriptionOId { get; set; }

        public virtual Subscription Subscription { get; set; }

        public virtual User User { get; set; }
        public string Settings { get; set; }

    }
}
