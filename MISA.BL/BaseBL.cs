using MISA.BL.Interfaces;
using MISA.DL;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.BL
{
    public class BaseBL<T>: IBaseBL<T> where T : BaseEntity
    {
        IBaseDL<T> _baseDL;
        //BaseDL<T> _baseDL;
        public BaseBL(IBaseDL<T> baseDL)
        {
            //_baseDL = new DL.BaseDL<T>();
            _baseDL = baseDL;
        }
        public IEnumerable<T> GetData()
        {
            return _baseDL.GetData();
        }


        public void Insert(T entity)
        {
           //_baseDL.Insert(entity);
        }
    }
}
