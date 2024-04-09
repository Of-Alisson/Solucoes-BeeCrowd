using System;

namespace CSharp
{
    public class Cs1020
    {
        public static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            int anos = dias / 365;
            dias -= (anos * 365);

            int meses = dias / 30;
            dias -= (meses * 30);

            Console.WriteLine("{0} ano(s)", anos);
            Console.WriteLine("{0} mes(es)", meses);
            Console.WriteLine("{0} dia(s)", dias);
        }
    }
}