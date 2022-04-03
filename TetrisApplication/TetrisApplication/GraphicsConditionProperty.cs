using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApplication
{
    public class GraphicsConditionProperty : IGrahicsCondition
    {
        private readonly TetrisField _tetrisField;

        public Graphics Graphics => throw new NotImplementedException();

        public Size Size => _tetrisField.Size;

        public GraphicsConditionProperty(TetrisField tetrisField)
        {
            _tetrisField = tetrisField;
        }
    }
}
