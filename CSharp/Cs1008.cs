using System;

namespace CSharp
{
    public class Cs1008
    {
        public static void Main(string[] args)
        {
            double salario;
        
            int n = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double vh = double.Parse(Console.ReadLine());
            
            salario = h * vh;
            
            Console.WriteLine("NUMBER = {0}", n);
            Console.WriteLine("SALARY = U$ {0:F2}", salario);
        }
    }
}