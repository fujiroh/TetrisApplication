using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisApplication
{
    public partial class TetrisField : UserControl
    {
        private readonly TetrisFieldBlockList _tetrisFieldBlockList;
        private readonly IGrahicsCondition _graphicsCondition;

        public TetrisField()
        {
            InitializeComponent();

            _graphicsCondition = new GraphicsConditionProperty(this);
            _tetrisFieldBlockList = new TetrisFieldBlockList(_graphicsCondition);

            SetBlock_Test();
        }

        private void TetrisField_Paint(object sender, PaintEventArgs e)
        {
            _tetrisFieldBlockList.DrawFileld(e.Graphics);
        }

        private void SetBlock_Test()
        {

        }
    }
}
