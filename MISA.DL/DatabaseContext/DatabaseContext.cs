using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class DatabaseContext : IDatabaseContext
    {
        public IEnumerable<T> GetData<T>() where T: BaseEntity
        {
            return null;
        }
    }
}
