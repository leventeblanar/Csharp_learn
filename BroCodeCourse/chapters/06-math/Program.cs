using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;

            double a = System.Math.Pow(x, 3);
            double b = System.Math.Sqrt(x);
            double c = System.Math.Abs(x);
            double d = System.Math.Round(x);
            double e = System.Math.Ceiling(x);
            double f = System.Math.Floor(x);
            double g = System.Math.Max(x, y);
            double h = System.Math.Min(x, y);

            Console.WriteLine(b);
        }
    }
}