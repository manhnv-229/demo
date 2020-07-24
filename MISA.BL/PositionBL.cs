using MISA.BL.Interfaces;
using MISA.DL;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class PositionBL:BaseBL<Position>, IPositionBL
    {
        public PositionBL(IPositionDL positionDL) : base(positionDL)
        {

        }
    }
}
