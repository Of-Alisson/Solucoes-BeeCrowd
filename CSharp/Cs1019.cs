using System;

namespace CSharp
{
    public class Cs1019
    {
        public static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());

            int h = segundos / 3600;
            int resto = segundos % 3600;

            int m = resto / 60;
            int s = resto % 60;

            Console.WriteLine("{0}:{1}:{2}", h, m, s);
            Console.ReadKey();
        }
    }
}