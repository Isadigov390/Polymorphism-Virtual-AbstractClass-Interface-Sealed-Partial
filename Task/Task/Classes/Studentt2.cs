namespace Task.Classes
{
    internal class Studentt2 : Person
    {
        private double _point;
        public double Point {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0 && value <= 100) { _point = value; }
            }
        }
        public Studentt2(string name, string surname,double point) : base(name, surname)
        {
            Point = point;
        }
    }
}
