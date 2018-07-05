using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            Roles = new HashSet<Role>();

        }
        public virtual HashSet<Role> Roles { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int LCID { get; set; }
        public string Name { get; set; }

        public bool ForceLogout { get; set; }

        public string ResetPassToken { get; set; }
        public int? Account_Id { get; set; }
        [ForeignKey("Account_Id")]
        public virtual Account Account { get; set; }

        public bool ShowWizard { get; set; }
    }
}
