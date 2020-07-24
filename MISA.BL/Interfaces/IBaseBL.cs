using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL.Interfaces
{
    public interface IBaseBL<T>
    {
        IEnumerable<T> GetData();
    }
}
