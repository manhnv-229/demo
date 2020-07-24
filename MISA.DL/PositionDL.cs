using Microsoft.EntityFrameworkCore;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class PositionDL : BaseDL<Position>, IPositionDL
    {
        public PositionDL(IDatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
