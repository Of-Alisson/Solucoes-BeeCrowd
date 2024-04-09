using System;

namespace CSharp
{
    public class Cs1007
    {
        public static void Main(string[] args)
        {
            int DIFERENCA;
        
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            
            DIFERENCA = (A * B - C * D);
            
            Console.WriteLine("DIFERENCA = {0}", DIFERENCA);

        }
    }
}