using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class Account : EntityBase
    {

        public Account()
        {
            //  Transactions = new HashSet<Transaction>();
            Subscriptions = new List<Subscription>();

            Users = new List<User>();

        }

        public virtual List<Subscription> Subscriptions { get; set; }
        public virtual ICollection<User> Users { get; set; }

        //public int TimeZoneOffset { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }


    }
}
