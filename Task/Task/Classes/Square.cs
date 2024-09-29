

namespace Task.Classes
{
    internal class Square : Figure
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }
        public override int CalcArea()
        {
            if (Side <= 0) return -1;

            return Side *Side;
        }
    }
}
