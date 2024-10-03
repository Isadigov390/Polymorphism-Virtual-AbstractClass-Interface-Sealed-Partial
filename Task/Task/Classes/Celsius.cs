namespace Task.Classes
{
    internal class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celsius(Kelvin degree)
        {

            return new Celsius(degree.Degree-273.15);
        }

    }
}
