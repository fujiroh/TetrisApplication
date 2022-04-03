using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    /// <summary>
    /// ミノの基底クラス
    /// </summary>
    public class MinoBase : IMovable, IRotatable
    {
        private readonly BlockList _blocks;

        public MinoBase(int row, int col)
        {
            _blocks = new BlockList(row, col);
        }

        public 
            
            
            void Move(MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up: break;
                case MoveDirection.Down: break;
                case MoveDirection.Right: break;
                case MoveDirection.Left: break;
                default: break;
            }
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }

        // 初期ブロックの設定
        protected virtual void SetInitialBlock()
        {

        }
    }
}
