using System;

namespace Ordenar_Vector_Burbujero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int largo = 20;
            int[] vector = new int[largo];
            Random rnd = new Random();
            int aux = 0;
            bool desordenado = false;
            int contador = 0;

            Console.WriteLine("Vector Desordenado");

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);

                Console.Write($"{vector[i]}");

                if (i < (vector.Length-1))
                {
                    Console.Write("-");
                }
            }


            Console.WriteLine("\nVector Ordenado");

            // Vamos a ordenarlo

            do
            {
                desordenado = false;

                for (int i = 0; i < vector.Length - 1; i++)
                {
                    if (vector[i] > vector[i+1])
                    {
                        desordenado=true;
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;

                    }
                }

                contador++;

            } while (desordenado);




            Console.WriteLine($"Contador: {contador}");


            for (int i = 0; i < vector.Length; i++)
            {
                           Console.Write($"{vector[i]}");

                    if (i < (vector.Length - 1))
                    {
                        Console.Write("-");
                    }
                }


            

            Console.ReadKey();



        }
    }
}
