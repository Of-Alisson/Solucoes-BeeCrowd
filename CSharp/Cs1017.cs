using System;

namespace CSharp
{
    public class Cs1017
    {
        public static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int kmh = int.Parse(Console.ReadLine());

            double d = h * kmh;
            double l = d / 12;

            Console.WriteLine("{0:F3}", l);
        }
    }
}