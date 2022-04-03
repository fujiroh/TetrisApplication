using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    /// <summary>
    /// ブロックのまとまり
    /// </summary>
    public class BlockList
    {
        private readonly TetrisBlock[,] _tetrisFieldBlocks;

        /// Indexerプロパティ
        public TetrisBlock this[int vertical, int horizontal]
        {
            get { return _tetrisFieldBlocks[vertical, horizontal]; }
            set { _tetrisFieldBlocks[vertical, horizontal] = value; }
        }

        public BlockList(int vertical,int horizontal)
        {
            _tetrisFieldBlocks = new TetrisBlock[vertical, horizontal];
            SetInitialFieldBlock(vertical,horizontal);
        }


        /// フィールドをNoneで初期化
        private void SetInitialFieldBlock(int vertical,int horizontal)
        {
            for (int ver = 0; ver < vertical; ver++)
            {
                for (int hol = 0; hol < horizontal; hol++)
                {
                    _tetrisFieldBlocks[ver, hol] = new TetrisBlock();
                }
            }
        }
    }
}
