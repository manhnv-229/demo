using MISA.DL;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.BL
{
    public class EFDatabaseContext : IDatabaseContext
    {
        public IEnumerable<T> GetData<T>() where T: BaseEntity
        {
            DemoContext demoContext = new DemoContext();
            var data = demoContext.Set<T>().ToList();
            return data;
        }
    }
}
