using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    public class TetrisCoreBlock : TetrisBlock
    {
        public Coordinate Coordinate { get; set; }

        public TetrisCoreBlock(Coordinate coordinate, MinoType minoType)
        {
            Coordinate = coordinate;
            MinoType = minoType;
        }
    }
}
