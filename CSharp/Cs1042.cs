using System;

namespace CSharp
{
    public class Cs1042
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);
            int z = int.Parse(line[2]);

            if (x <= y && y <= z)
            {
                Console.WriteLine("{0}{1}{2}",x +"\n",y +"\n",z + "\n");
                

            }
            else
            {
                if (x <= z && z <= y )
                {
                    Console.WriteLine("{0}{1}{2}", x + "\n", z + "\n", y + "\n");
                    
                }
                else
                {
                    if (y <= x && x <= z)
                    {
                    Console.WriteLine("{0}{1}{2}", y + "\n", x + "\n", z + "\n");
                    
                    }
                    else
                    {
                        if (y <= z && z <= x)
                        {

                            Console.WriteLine("{0}{1}{2}", y + "\n", z + "\n", x + "\n");
                            
                        }
                        else
                        {
                            if (z <= x && x <= y)
                            {

                                Console.WriteLine("{0}{1}{2}", z + "\n", x + "\n", y + "\n");
                                
                            }
                            else
                            {
                                if (x == y && y == z)
                                {

                                    Console.WriteLine("{0}{1}{2}", x + "\n", y + "\n", z + "\n");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("{0}{1}{2}", z + "\n", y + "\n", x + "\n");
                                    
                                }
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("{0}{1}{2}", x + "\n", y + "\n", z);
        }
    }
}