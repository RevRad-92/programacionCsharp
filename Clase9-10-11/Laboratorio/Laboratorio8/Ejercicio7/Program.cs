using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 7");

            int[] factAnual = new int[12];
            Random random = new Random();
            int fact = 0;
            int[] factTrimestres = new int[4];

            for (int i = 0; i < factAnual.Length; i++)
            {
                fact = random.Next(5000, 50000);
                factAnual[i] = fact;
            }

            // VER FACTURACION ANUAL AUTOGENERADA:
            Console.WriteLine("Facturación Anual:");

            for (int i = 0; i < factAnual.Length; i++)
            {
                Console.WriteLine($"Mes {i + 1}: ${factAnual[i]}");
            }

            //  factTrimestres[0] --> 1er trimestre
            //  factTrimestres[1] --> 2do trimestre
            //  factTrimestres[2] --> 3er trimestre
            //  factTrimestres[3] --> 4to trimestre

            for (int i = 0; i < factAnual.Length; i++)
            {
                if (i < 3)
                {
                    factTrimestres[0] += factAnual[i];
                }

                if (i >= 3 && i <= 5)
                {
                    factTrimestres[1] += factAnual[i];
                }

                if (i > 5 && i <= 8)
                {
                    factTrimestres[2] += factAnual[i];
                }

                if (i > 8)
                {
                    factTrimestres[3] += factAnual[i];
                }


            }

            // VER FACT TRIMESTRAL
            Console.WriteLine("\nFacturacion trimestral: ");
            for (int i = 0; i < factTrimestres.Length; i++)
            {
                Console.WriteLine($"Trimestre {i + 1}: ${factTrimestres[i]}");
            }

            Console.ReadKey();

        }
    }
}
