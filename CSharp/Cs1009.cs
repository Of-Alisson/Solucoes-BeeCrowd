using System;

namespace CSharp
{
    public class Cs1009
    {
        public static void Main(string[] args)
        {
            string Nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendasr = double.Parse(Console.ReadLine());
            double total = ((vendasr * 15) / 100) + salario;
            
            Console.WriteLine("TOTAL = R$ {0:F2}", total);
        }
    }
}