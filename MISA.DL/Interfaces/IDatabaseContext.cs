using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DL.Interfaces
{
    public interface IDatabaseContext
    {
        IEnumerable<T> GetData<T>() where T: BaseEntity;
    }
}
