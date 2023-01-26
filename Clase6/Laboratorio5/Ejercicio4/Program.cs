using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");
            int n = 1;

            while (n <= 10)
            {
                if (n != 2 && n != 5 && n != 9)
                {
                    Console.WriteLine($"n = {n}");
                }

                // opcion 2: usar continue:
                //if (n == 2 || n == 5 || n == 9 )
                //{
                //    n++;
                //    continue;
                //}
                //Console.WriteLine($"n = {n}");

                n++;
            }


            Console.ReadKey();
        }
    }
}
