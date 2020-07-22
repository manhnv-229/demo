using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class BaseDL<T> where T: BaseEntity
    {
        public IEnumerable<T> GetData()
        {
            DemoContext demoContext = new DemoContext();
            var data = demoContext.Set<T>().ToList();
            return data;
        }

        public void Insert(T entity)
        {
            DemoContext demoContext = new DemoContext();
            demoContext.Set<T>().Add(entity);
            demoContext.SaveChanges();
        }
    }
}
