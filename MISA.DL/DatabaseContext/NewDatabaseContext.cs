using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL.DatabaseContext
{
    public class NewDatabaseContext : IDatabaseContext
    {
        public IEnumerable<T> GetData<T>() where T : BaseEntity
        {
            DemoContext demoContext = new DemoContext();
            var data = demoContext.Set<T>().ToList().Take(1);
            return data;
        }
    }
}
