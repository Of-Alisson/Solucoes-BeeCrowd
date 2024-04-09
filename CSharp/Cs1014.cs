using System;

namespace CSharp
{
    public class Cs1014
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double media = X / Y;
            Console.WriteLine("{0:F3} km/l", media);
        }
    }
}