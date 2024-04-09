using System;

namespace CSharp
{
    public class Cs1044
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0]);
            double b = double.Parse(line[1]);
        
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}