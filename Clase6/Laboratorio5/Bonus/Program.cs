using System;

namespace Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonus (Factoriales)");
            int input = 0;
            int x = 1;
            int factorial = 1;
                       

            Console.Write("Ingrese número: ");
            input = Convert.ToInt32(Console.ReadLine());


            while (x <= input)
            {
                factorial *= x;
                x++;
            }
            
            Console.WriteLine($"Factorial de {input} es {factorial}");


            Console.ReadKey();
        }
    }
}
