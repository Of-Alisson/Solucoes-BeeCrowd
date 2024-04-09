using System;

namespace CSharp
{
    public class Cs1018
    {
        public static void Main(string[] args)
        {
            int nota1 = 1;
            int nota2 = 2;
            int nota5 = 5;
            int nota10 = 10;
            int nota20 = 20;
            int nota50 = 50;
            int nota100 = 100;

            int notasinseridas = int.Parse(Console.ReadLine());
        
            int atual = notasinseridas;
            nota100 = atual / 100;
            atual -= nota100 * 100;
            nota50 = atual / 50;
            atual -= nota50 * 50;
            nota20 = atual / 20;
            atual -= nota20 * 20;
            nota10 = atual / 10;
            atual -= nota10 * 10;
            nota5 = atual / 5;
            atual -= nota5 * 5;
            nota2 = atual / 2;
            atual -= nota2 * 2;
            nota1 = atual;

            Console.WriteLine("{0}", notasinseridas);
            Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);
            Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);
            Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);
            Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);
            Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);
            Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);
            Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);
        }
    }
}