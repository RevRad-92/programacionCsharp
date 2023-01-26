using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");
            double dinero = 1000;
            int mes = 1;

            while (mes <= 12)
            {
                dinero *= 1.02;
                //Console.WriteLine($"El total acumulado en el mes {mes} es = {"0:N2",dinero}");
                Console.WriteLine($"El total acumulado en el mes {mes} es = " + "{0:N2}", dinero);
                mes++;
            }



            Console.ReadKey();
        }
    }
}
