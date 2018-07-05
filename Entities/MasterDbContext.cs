using System.Collections.Generic;
using System.Data.Entity;


namespace Task3.Entities
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext(string cn)
           : base(cn)
        {

        }
        public MasterDbContext()
          : base()
        {

        }
        public  DbSet<Subscription> Subscription { get; set; }
        public  DbSet<User> User { get; set; }

        public  DbSet<Role> Role { get; set; }
    }
}
