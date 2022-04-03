using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    public class TTypeMino : MinoBase
    {
        private const int ROW_NUMBER = 2;
        private const int COL_NUMBER = 3;
        private Color _blockColor = Color.Purple;
        private readonly BlockList _blockList;


        public TTypeMino(Coordinate coordinate)
            : base(ROW_NUMBER, COL_NUMBER)
        {
            _blockList = new BlockList(ROW_NUMBER, COL_NUMBER);
            SetInitialBlock();
        }

        private void SetInitialBlock(Coordinate coordinate)
        {
            _blockList[0, 1] = new TetrisBlock(MinoType.T);
            _blockList[1, 0] = new TetrisBlock(MinoType.T);
            _blockList[1, 1] = new TetrisCoreBlock(coordinate, MinoType.T);
            _blockList[1, 2] = new TetrisBlock(MinoType.T);
        }
    }
}
