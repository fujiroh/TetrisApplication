namespace TetrisApplication
{
    public class TetrisBlock : IEquatable<TetrisBlock>
    {
        public MinoType MinoType { get; set; }

        public TetrisBlock()
        {
            MinoType = MinoType.None;
        }

        public TetrisBlock(MinoType state)
        {
            MinoType = state;
        }

        public virtual void Draw(
            Graphics graphics,
            Color brushColor,
            Color penColor,
            Rectangle rectangle)
        {
            using (var brush = new SolidBrush(brushColor))
            using (var pen = new Pen(penColor))
            {
                graphics.FillRectangle(brush, rectangle);
                graphics.DrawRectangle(pen, rectangle);
            }
        }

        public bool Equals(TetrisBlock? other)
        {
            return MinoType == other.MinoType;
        }
    }
}
