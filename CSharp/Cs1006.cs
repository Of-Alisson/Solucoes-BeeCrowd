using System;

namespace CSharp
{
    public class Cs1006
    {
        public static void Main(string[] args)
        {
            double media;
        
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
        
            media = ((A * 2) + (B * 3) + (C * 5)) / 10;
        
            Console.WriteLine("MEDIA = {0:F1}", media);
        }
    }
}
