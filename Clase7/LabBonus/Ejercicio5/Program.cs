using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");
            double dinero = 1000;
            int mes = 1;

            while (mes <= 12)
            {
                dinero *= 1.03;
                
                Console.WriteLine($"El total acumulado en el mes {mes} es = " + "{0:N2}", dinero);

                if (dinero >= 1200)
                {
                    break;
                }

                mes++;
            }



            Console.ReadKey();
        }
    }
}
