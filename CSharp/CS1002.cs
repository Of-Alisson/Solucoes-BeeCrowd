using System;

namespace CSharp
{
    public class Cs1002
    {
        public static void Main(string[] args)
        {
            double pi = 3.14159, r;

            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A=" + (pi * (r * r)).ToString("0.0000"));
        }
    }
}