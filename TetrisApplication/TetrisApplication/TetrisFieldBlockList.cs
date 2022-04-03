using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    /// <summary>
    /// テトリスのフィールド状況をリストで管理
    /// </summary>
    public class TetrisFieldBlockList
    {
        private const int VERTICAL_BLOCK_NUM = 30;
        private const int HORIZOTAL_BLOCK_NUM = 15;
        private readonly IGrahicsCondition _grahicsCondition;

        public readonly BlockList _tetrisFieldBlocks;

        /// Indexerプロパティ
        public TetrisBlock this[int vertical, int horizontal]
        {
            get { return _tetrisFieldBlocks[vertical, horizontal]; }
            set { _tetrisFieldBlocks[vertical, horizontal] = value; }
        }


        /// コンストラクタ
        public TetrisFieldBlockList()
        {
            _tetrisFieldBlocks = new BlockList(VERTICAL_BLOCK_NUM,HORIZOTAL_BLOCK_NUM);
            SetInitialFieldBlock();
        }

        public TetrisFieldBlockList(IGrahicsCondition grahicsCondition)
        {
            _tetrisFieldBlocks = new BlockList(VERTICAL_BLOCK_NUM, HORIZOTAL_BLOCK_NUM);
            SetInitialFieldBlock();

            _grahicsCondition = grahicsCondition;
        }

        /// フィールドをNoneで初期化
        private void SetInitialFieldBlock()
        {
            for (int ver = 0; ver < VERTICAL_BLOCK_NUM; ver++)
            {
                for (int hol = 0; hol < HORIZOTAL_BLOCK_NUM; hol++)
                {
                    _tetrisFieldBlocks[ver, hol] = new TetrisBlock();
                }
            }
        }

        public void DrawFileld(Graphics graphics)
        {
            for (int ver = 0; ver < VERTICAL_BLOCK_NUM; ver++)
            {
                for (int hol = 0; hol < HORIZOTAL_BLOCK_NUM; hol++)
                {
                    var block = _tetrisFieldBlocks[ver, hol];

                    block.Draw(
                        graphics,
                        GetColor(block.MinoType),
                        Color.Gray,
                        GetRectangle(ver, hol));
                }
            }
        }

        private Rectangle GetRectangle(int indexRow, int indexCol)
        {
            return new Rectangle(GetUnitBlockLocation(indexRow, indexCol), GetunitBlockSize());
        }

        private Size GetunitBlockSize()
        {
            var edgeLength = GetSmallerEdge();
            return new Size(edgeLength, edgeLength);
        }

        private Point GetUnitBlockLocation(int indexRow, int indexCol)
        {
            var blockSize = GetSmallerEdge();
            return new Point(blockSize * indexCol, blockSize * indexRow);
        }

        private int GetSmallerEdge()
        {
            var width = _grahicsCondition.Size.Width;
            var height = _grahicsCondition.Size.Height;

            return Math.Min(height / VERTICAL_BLOCK_NUM, width / HORIZOTAL_BLOCK_NUM);
        }

        private Color GetColor(MinoType type)
        {
            switch (type)
            {
                case MinoType.I: return Color.SkyBlue;
                case MinoType.O: return Color.Yellow;
                case MinoType.T: return Color.Purple;
                case MinoType.J: return Color.Blue;
                case MinoType.L: return Color.Orange;
                case MinoType.S: return Color.Red;
                case MinoType.Z: return Color.Green;
                case MinoType.None:
                default: return Color.Transparent;
            }
        }
    }
}
