using MISA.DL;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class PositionBL
    {
        public IEnumerable<Position> GetPositions()
        {
            PositionDL positionDL = new PositionDL();
            return positionDL.GetPositions();
        }
    }
}
