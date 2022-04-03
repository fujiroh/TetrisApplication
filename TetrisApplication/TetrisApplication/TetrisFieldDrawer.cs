using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    /// <summary>
    /// テトリスの盤面を描画する
    /// </summary>
    public class TetrisFieldDrawer
    {
        private readonly IGrahicsCondition _grahicsCondition;

        public TetrisFieldDrawer(IGrahicsCondition grahicsCondition)
        {
            _grahicsCondition = grahicsCondition;
        }

        public static void DrawFild(
            TetrisFieldBlockList blockList,
            Graphics graph)
        {

        }
    }
}
