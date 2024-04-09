using System;

namespace CSharp
{
    public class Cs1016
    {
        public static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());

            int tempo = (km * 2);

            Console.WriteLine("{0} minutos", tempo);
            Console.ReadKey();
        }
    }
}