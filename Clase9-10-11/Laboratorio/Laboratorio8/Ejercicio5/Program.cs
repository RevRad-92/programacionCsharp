using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");

            int[] arrayOrigen = { 1002, 104, 309, 500 };
            int[] arrayDestino = new int[arrayOrigen.Length];

            for (int i = 0; i < arrayOrigen.Length; i++)
            {
                arrayDestino[i] = arrayOrigen[i];
            }

            for (int i = 0; i < arrayDestino.Length; i++)
            {
                Console.WriteLine($"Indice: {i} - Valor: {arrayDestino[i]}");
            }

        }
    }
}
