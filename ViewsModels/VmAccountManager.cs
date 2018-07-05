using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task3.Enums;

namespace Task3.ViewsModels
{
    public class VmAccountManager
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public EnumMasterRoleType RoleType { get; set; }
    }
}
