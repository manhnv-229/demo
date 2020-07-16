using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class PositionDL
    {
        public IEnumerable<Position> GetPositions()
        {
            DemoContext demoContext = new DemoContext();
            return demoContext.Position.ToList();
        }
    }
}
