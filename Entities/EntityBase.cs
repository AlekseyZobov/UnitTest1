using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            State = 1;
        }
        public int Id { get; set; }

        public int ServiceCode { get; set; }

        public Guid OId { get; set; }

        public int State { get; set; }

        public string Tags { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateChanged { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

    }
}
