using System;
using System.Security.Cryptography.X509Certificates;

namespace Eje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            
            int unidades = 0;
            Random rnd = new Random();
            int autoA, autoB, autoC;
            autoA = 4000000;
            autoB = 4550000;
            autoC = 5600000;

            int y = 3;
            int x = 15;

            double[,] matriz = new double[y, x];
            double promedio = 0;
            double total = 0;




            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1) - 3; j++)
                {
                     
                    matriz[i, j] = rnd.Next(1, 100);
                    matriz[i, 13] += matriz[i, j] ; // total unidades vendidas
                    matriz[i, 12] = matriz[i, 13] / 12; // promedio unidades vendidas

                }
                
            }

            // Ganancias netas anuales [i, 14]

            // autoA 
            total = matriz[0, 13];
            matriz[0, 14] = total * autoA * 0.2;

            // autoB
            total = matriz[1, 13];
            matriz[1, 14] = total * autoB * 0.2;
            
            // autoC
            total = matriz[2, 13];
            matriz[2, 14] = total * autoC * 0.2;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"|{Math.Round(matriz[i, j], 0)}");
                }
                Console.WriteLine();
            }


            Console.ReadKey();


        }
    }
}
