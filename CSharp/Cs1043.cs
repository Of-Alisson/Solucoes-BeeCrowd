using System;

namespace CSharp
{
    public class Cs1043
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0]);
            double b = double.Parse(line[1]);
            double c = double.Parse(line[2]);

            if (a + b > c && b + c > a && a + c > b)
            {
                double p = a + b + c;
                Console.WriteLine("Perimetro = {0:F1}", p);
            }
            else
            {
                double ar = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0:F1}", ar);
            }
        }
    }
}