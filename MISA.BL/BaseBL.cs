using MISA.DL;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.BL
{
    public class BaseBL<T> where T: BaseEntity
    {
        public IEnumerable<T> GetData()
        {
            var baseDL = new DL.BaseDL<T>();
            return baseDL.GetData();
        }
        

        public void Insert(T entity)
        {
            var baseDL = new DL.BaseDL<T>();
            baseDL.Insert(entity);
        }
    }
}
