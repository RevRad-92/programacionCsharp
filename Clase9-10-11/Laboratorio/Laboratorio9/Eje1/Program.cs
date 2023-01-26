using System;
using System.Numerics;

namespace Eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");


            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            string[] years = { "2018", "2019", "2020"};

            double[,] matriz = new double[3, 12];

            double infmax = matriz[0,0];
            double infmin = matriz[0,0];
            double promedio = 0;
            double total = 0;
            int posicionMesMax = 0;
            int posicionMesMin = 0;

            double[] infAnual = new double[3];
            double infYearMax = infAnual[0];
            int posYearMax = 0;
            

            Random random = new Random();

            

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"Año {years[i]}");
                infmax = matriz[i,0];
                infmin = 100; // si no, es siempre 0 desde que se declaró.
                promedio = 0;
                total = 0;
                posicionMesMax = 0;
                posicionMesMin = 0;

                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 10) + Math.Round(random.NextDouble(), 2);
                    Console.WriteLine($"{meses[j]}: {Math.Round(matriz[i, j], 2)}%");

                    if (matriz[i, j] > infmax)
                    {
                        infmax = matriz[i, j];
                        posicionMesMax = j;
                    }

                    if (matriz[i, j] < infmin)
                    {
                        infmin = matriz[i, j];
                        posicionMesMin = j;
                    }

                    total += matriz[i, j];
                    promedio = total / 12;

                }

                Console.WriteLine($"La inflación máxima de {years[i]} fue {meses[posicionMesMax]}: {Math.Round(infmax, 2)}%");
                Console.WriteLine($"La inflación mínima de {years[i]} fue {meses[posicionMesMin]}: {Math.Round(infmin, 2)}%");
                Console.WriteLine($"La inflación total anual de {years[i]} fue: {Math.Round(total, 2)}%");
                Console.WriteLine($"El promedio de inflación anual de {years[i]} fue: {Math.Round(promedio, 2)}%");

                infAnual[i] = total;

                if (infAnual[i] > infYearMax)
                {
                    infYearMax = infAnual[i];
                    posYearMax = i;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"El año {years[posYearMax]} fue el de mayor inflación: {Math.Round(infYearMax, 2)}%");


            Console.ReadKey();

        }
    }
}
