using System;
using System.Security.Cryptography;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 1");
            int[,] rally = new int[6, 13]; // fila x columna (competidores x tramos+3 (promedio, mejor, total))
            string[,] drivers = { { "Kalle Rovanperä", "" }, { "Ott Tänak", "" }, { "Thierry Neuville", "" }, { "Elfyn Evans", "" }, { "Takamoto Katsuta", "" }, { "Sébastien Ogier", "" } };
            int promedio;
            int best;
            int total = 0;
            int overallBest;
            int posOvBest;
            Random random = new Random();


            // COMPLETAR MATRIZ CON TIEMPOS

            for (int i = 0; i < rally.GetLength(0); i++)
            {
                // i = competidor
                //best = 300;
                best = rally[i, 0];

                for (int j = 0; j < 10; j++)
                {
                    // j = tramo
                    rally[i, j] = random.Next(75, 301); // tiempo de tramo
                    if (best == 0) // INNECESARIO SI SETEAS BEST con un NUMERO MUY ALTO
                    {
                        best = rally[i, j];
                    }

                    if (rally[i, j] < best)
                    {
                        best = rally[i, j];
                        rally[i, 11] = best;
                    }
                    else
                    {
                        rally[i, 11] = best;
                    }

                    total += rally[i, j];
                    promedio = total / 10;
                    rally[i, 10] = promedio;
                    rally[i, 12] = total; // reemplazar por funcion que convierta
                    // rally[i, 12] = ConvertirTiempo(total); // error, string en int de matriz

                }

                total = 0;

            }

            // MOSTRAR MATRIZ
            

            for (int i = 0; i < rally.GetLength(0); i++)
            {
                Console.Write($" {drivers[i, 0]} |");
                for (int j = 0; j < rally.GetLength(1); j++)
                {
                    Console.Write($" {rally[i, j]} |");
                }
                Console.WriteLine();
            }



            // mostrar pilotos con tiempo total convertido a HH:MM:SS
            Console.WriteLine("\nResultados Finales -- SIN ORDEN\n");


            for (int i = 0; i < drivers.GetLength(0); i++)
            {
                for (int j = 0; j < drivers.GetLength(1); j++)
                {
                    drivers[i, 1] = ConvertirTiempo(rally[i, 12]);

                    Console.Write($"{drivers[i, j]} - ");
                }

                Console.WriteLine();
            }

            // CALCULAR GANADOR 
            overallBest = rally[0, 12];
            posOvBest = 0;

            for (int i = 0; i < rally.GetLength(0); i++)
            {
                
                if (rally[i, 12] < overallBest)
                {
                    overallBest = rally[i, 12];
                    posOvBest = i;
                }

            }

            
            Console.WriteLine($"El ganador del Rally es {drivers[posOvBest, 0]} - Tiempo total: {drivers[posOvBest, 1]}");

            Console.ReadKey();

        }

        static string ConvertirTiempo(int tiempo)
        {
            // opcion B
            /*
            int horas = tiempo / 3600;
            int minutos = ((tiempo - horas * 3600) / 60);
            int segundos = ((tiempo - (horas *3600 + minutos * 60);
            */


            int segundos = tiempo;
            int minutos = segundos / 60;
            int horas = minutos / 60;
            minutos = minutos % 60;
            segundos = segundos % 60;
            string showMinutes;
            string showSeconds;

            if (minutos < 10)
            {
                showMinutes = $"0{Convert.ToString(minutos)}";

            }
            else
            {
                showMinutes = $"{Convert.ToString(minutos)}";

            }

            if (segundos < 10)
            {
                showSeconds = $"0{Convert.ToString(segundos)}";

            }
            else
            {
                showSeconds = $"{Convert.ToString(segundos)}";
            }

            return $"{horas}:{showMinutes}:{showSeconds}";
        }
    }
}
