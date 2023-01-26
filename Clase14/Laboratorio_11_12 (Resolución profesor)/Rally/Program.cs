using System;

namespace Rally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dada una Matriz diseñada para una carrera de Rally de 10 tramos y 6 competidores
 Completar el tiempo(segundos) de cada competidor en cada tramo
 Calcular en una columna el promedio de tiempo de los tramos
 Completar el mejor tiempo.
 Informar el tiempo total de Cada Competidor
 Con una función pasar el tiempo total: HH: MM: SS
 Informar el Ganador
Condiciones Previas: El mínimo de tiempo por cada tramo es de 75 segundos.El máximo es 300 segundos
            */

            int x = 13;
            int y = 6;

            int[,] matriz = new int[x, y];
            Random rnd = new Random();

            int ganador = 0;
            int tiempoGanador = 0;

            // Completo los 10 tramos ,promedio , mejor tiempo y total


            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                matriz[11, i] = 100000000;

                for (int j = 0; j < matriz.GetLength(0) - 3; j++)
                {
                    matriz[j, i] = rnd.Next(75, 300);// Valor del tramo 
                    matriz[12, i] += matriz[j, i]; // Total
                    matriz[10, i] = matriz[12, i] / 10; // Promedio

                    if (matriz[11, i] > matriz[j, i])
                    {

                        matriz[11, i] = matriz[j, i];



                    }



                }

            }

            // Imprimir 


            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                Console.Write($"Competidor n°:{i + 1} =>");

                for (int j = 0; j < matriz.GetLength(0); j++)
                {

                    Console.Write($"|{matriz[j, i]}");


                }


                Console.WriteLine();




            }

            tiempoGanador = matriz[12, 2];

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                if (tiempoGanador > matriz[12,i])
                {
                    tiempoGanador = matriz[12, i];
                    ganador = i;
                
                
                }

                Console.WriteLine($"El tiempo del auto n° {i+1} fue de {FormatearHHMMSS(matriz[12, i])}");

            }

            Console.WriteLine($"El auto Ganador es el n° {ganador + 1}");









            Console.ReadKey();
















































        }

        static string FormatearHHMMSS(int tiempo)
        {

            int horas = tiempo / 3600;// Extraigos las horas enteras de los segundos
            int minutos = ((tiempo - horas * 3600) / 60);// A lo que quedo lo transformo en minutos
            int segundos = tiempo - ( horas * 3600+ minutos *60);  // al tiempo que quedo (que no son horas ni minutos) 



            return horas.ToString()+":"+minutos.ToString()+":"+segundos.ToString();

        }



    }
}
