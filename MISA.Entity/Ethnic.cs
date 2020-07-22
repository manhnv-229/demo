using System;

namespace MISA.Entity
{
    public class Ethnic:BaseEntity
    {
        public Ethnic()
        {
            this.EthnicID = Guid.NewGuid();
        }
        public Guid EthnicID { get; set; }
        public string EthnicName { get; set; }
    }
}
