
namespace Task.Classes
{
    internal class Rectangular : Figure
    {
        public Rectangular(int width,int length)
        {
            Width=width;
            Length=length;
        }
        public int Width { get; set; }
        public int Length{ get; set; }
        public override int CalcArea()
        {
            if (Width <= 0 || Length<=0) return -1;
            return Length*Width;
        }
    }
}
