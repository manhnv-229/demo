using Microsoft.EntityFrameworkCore;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class BaseDL<T>: IBaseDL<T> where T: BaseEntity
    {
        IDatabaseContext _databaseContext;
        public BaseDL(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public virtual IEnumerable<T> GetData()
        {
            var data = _databaseContext.GetData<T>();
            return data;
        }

        //public virtual IEnumerable<T> GetData(string storeName)
        //{
        //    DemoContext demoContext = new DemoContext();
        //    var data = demoContext.Set<T>().FromSqlRaw("CALL GetPositions").ToList();
        //    return data;
        //}

        public void Insert(T entity)
        {
            DemoContext demoContext = new DemoContext();
            demoContext.Set<T>().Add(entity);
            demoContext.SaveChanges();
        }
    }
}
