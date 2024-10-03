namespace Task.Classes
{
    internal class Kelvin
    {
        public Kelvin(double degree)
        {
            Degree = degree;
        }
            
        public double Degree{ get; set; }
        public static implicit operator Kelvin(Celsius degree)
        {

            return new Kelvin(degree.Degree + 273.15);
        }
    }
}
