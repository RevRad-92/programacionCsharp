using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrices");

            // Declaro variables que me ayuden a definir el tamaño de mi matriz.

            int x = 3;
            int y = 2;

            // Declaro la matriz

            // Tipo de dato - Dimensión - Nombre
            int[,] numeros = { { 1, 4 }, { 5, 8 }, { 9, 6 } }; //  3x2
            // La cantidad de elementos es el producto de las longitudes
            int[,] matriz = new int[y, x]; // {{,,},{,,},{,,},{,,}} 4x3}

            // Declaro y asigno matriz 2x3 
            string[,] nombres = new string[2, 3];
            string[,] nombres2 = { {"Ana", "Karina", "Juan"},{ "Pablo", "Claudio", "Gimena" } };
            nombres[0, 0] = "Ana";
            nombres[0, 1] = "Karina";
            nombres[0, 2] = "Juan";
            nombres[1, 0] = "Pablo";
            nombres[1, 1] = "Claudio";
            nombres[1, 2] = "Gimena";


            matriz[0, 0] = 125;
            matriz[0, 1] = 200;
            matriz[0, 2] = 101;
            matriz[1, 0] = 478;
            matriz[1, 1] = 900;
            matriz[1, 2] = 551;


            Console.WriteLine("Recorro la matriz como 3 columnas y 2 filas");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"|{nombres[i, j]}");

                }

                Console.WriteLine(); // enter para bajar de fila
            }

            Console.WriteLine("Recorro la matriz como 2 columnas y 3 filas");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Console.Write($"|{nombres[j, i]}");

                }

                Console.WriteLine(); // enter para bajar de fila
            }


            // Matriz números con propiedad GetLength

            Console.WriteLine("Recorro la matriz como 3 columnas y 2 filas");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    Console.Write($"|{matriz[i, j]}");

                }

                Console.WriteLine(); // enter para bajar de fila
            }


            Console.WriteLine("Recorro la matriz como 2 columnas y 3 filas");

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {

                    Console.Write($"|{matriz[j, i]}");

                }

                Console.WriteLine(); // enter para bajar de fila
            }



            Console.ReadKey();

        }
    }
}
