using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task3.Enums;

namespace Task3.Entities
{
    public class Subscription : EntityBase
    {
        public Subscription()
        {
            Roles = new List<Role>();

        }

        public int? Account_Id { get; set; }
        [ForeignKey("Account_Id")]
        public virtual Account Account { get; set; }




        [Required]
        public string TimeZone { get; set; }

        public long SaasCounter { get; set; }

        public EnumSubscriptionType Type { get; set; }
        public decimal? MaxOverdraft { get; set; }

        public string Description { get; set; }
        public byte WeekStart { get; set; }
        public string Info { get; set; }

        public string CDNSettings { get; set; }



        public virtual List<Role> Roles { get; set; }

        public bool ShowOferta { get; set; }
        public bool ShowWizard { get; set; }
        public bool DoNotThrottle { get; set; }//only for external partners subscriptions
        public DateTime? LastTrafficCheck { get; set; }
        public string TrafficCheckEmails { get; set; }
        public bool Cutstat { get; set; }
        public int AdxConnectionType { get; set; }


        public bool AbleCreateLocalPartner { get; set; }

        public string MediatrustSettings { get; set; }

    }
}
