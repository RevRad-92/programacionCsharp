using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");

            double[] ingresos = new double[6];
            double total = 0;
            double promedio = 0;
            double max = 0;
            double min = 0;

            for (int i = 0; i < ingresos.Length; i++)
            {
                Console.WriteLine(ingresos[i]);
            }


            for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine(i);
                Console.Write($"Ingrese facturación del mes {i+1}: $");

                

                ingresos[i] = Convert.ToDouble(Console.ReadLine());
                total += ingresos[i];

                
            }

            min = ingresos[0];
            max = ingresos[0];

            for (int i = 0; i < ingresos.Length; i++)
            {
                if (ingresos[i] > max)
                {
                    max = ingresos[i];
                }

                if (ingresos[i] < min)
                {
                    min = ingresos[i];
                }
            }



            promedio = total / ingresos.Length;
            Console.WriteLine($"El promedio de facturación es: ${promedio}");
            Console.WriteLine($"El total facturado es: ${total}");
            Console.WriteLine($"La facturación máxima es: ${max}");
            Console.WriteLine($"La facturación mínima es: ${min}");
         

        }
    }
}
