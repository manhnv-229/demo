﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DL.Interfaces
{
    public interface IBaseDL<T>
    {
        IEnumerable<T> GetData();
    }
}
