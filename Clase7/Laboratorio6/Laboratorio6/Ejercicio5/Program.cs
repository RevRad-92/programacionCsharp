using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");
            int suma = 0;
            int multi = 1;

            for (int i = 1; i <= 5; i++)
            {
                suma += i;
                multi *= i;
                Console.WriteLine($"--- valor de i (ciclo) = {i}");
                Console.WriteLine($"valor de suma = {suma}");
                Console.WriteLine($"valor de multiplicación = {multi}");
                Console.WriteLine($"valor de multi - suma = {multi - suma}");

            }


            Console.ReadKey();
        }
    }
}
