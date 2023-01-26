using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 9");
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("@");

                }

                Console.WriteLine();
                
            }


            Console.ReadKey();
        }
    }
}
