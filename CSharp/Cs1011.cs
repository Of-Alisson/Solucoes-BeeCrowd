using System;

namespace CSharp
{
    public class Cs1011
    {
        public static void Main(string[] args)
        {
            double pi = 3.14159;

            double R = double.Parse(Console.ReadLine());
            double Volume = ((4/3.0) * pi * (R * R * R));
            
            Console.WriteLine ("VOLUME = {0:F3}", Volume);
        }
    }
}