using System.Diagnostics.CodeAnalysis;

namespace TetrisApplication
{
    public class Coordinate:IEqualityComparer<Coordinate>
    {
        public int X { get; set; }
        public int Y { get; set; }

        private Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coordinate Create(int x, int y)
        {
            return new Coordinate(x, y);
        }

        public static Coordinate operator +(Coordinate co1, Coordinate co2)
        {
            return new Coordinate(co1.X + co2.X, co1.Y + co2.Y);
        }

        public static Coordinate operator -(Coordinate co1, Coordinate co2)
        {
            return new Coordinate(co1.X - co2.X, co1.Y - co2.Y);
        }

        public static bool operator ==(Coordinate co1, Coordinate co2)
        {
            return co1.X == co2.X && co1.Y == co2.Y;
        }

        public static bool operator !=(Coordinate co1, Coordinate co2)
        {
            return co1.X != co2.X || co1.Y != co2.Y;
        }

        public bool Equals(Coordinate? co1, Coordinate? co2)
        {
            if(co1 == null)
            {
                return false;
            }
            if (co2 == null)
            {
                return false;
            }
            return co1 == co2;
        }

        public int GetHashCode([DisallowNull] Coordinate obj)
        {
            return GetHashCode();
        }
    }
}
