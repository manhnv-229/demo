using System;
using System.Collections.Generic;

namespace MISA.Entity
{
    public partial class Position:BaseEntity
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid PositionId { get; set; }
        public string PositionName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
