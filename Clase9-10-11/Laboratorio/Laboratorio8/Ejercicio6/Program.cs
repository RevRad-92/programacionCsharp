using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 6");

            int[] arrayOrigen = { 1002, 104, 309, 500 };
            int[] arrayDestino = new int[arrayOrigen.Length];





            //for (int i = arrayOrigen.Length - 1; i >= 0; i--)
            //{

            //    arrayDestino[arrayOrigen.Length - 1 - i] = arrayOrigen[i];

            //}

            // Solución profesor:

            int[] vecOrigen = { 1002, 104, 309, 500 };
            int[] vecDestino = { 0, 0, 0, 0 };

            for (int i = 0, j = vecOrigen.Length - 1 ; i < vecOrigen.Length; i++, j--)
            {
                vecDestino[j] = vecOrigen[i];
            }

            Console.WriteLine("vector Origen");
            for (int i = 0; i < vecOrigen.Length; i++)
            {
                Console.WriteLine(vecOrigen[i]);
            }

            Console.WriteLine("vector Destino");
            for (int i = 0; i < vecDestino.Length; i++)
            {
                Console.WriteLine(vecDestino[i]);
            }

            

            // Mi solución
            for (int i = 1 ; i <=  arrayOrigen.Length ; i++)
            {
                
                arrayDestino[arrayOrigen.Length - i] = arrayOrigen[i-1];
                
            }


            Console.WriteLine("Array Destino:");

            for (int i = 0; i < arrayDestino.Length; i++)
            {
                Console.WriteLine($"Indice: {i} - Valor: {arrayDestino[i]}");
            }

            
            
            //Console.WriteLine("Array Origen:");

            //for (int i = 0; i < arrayOrigen.Length; i++)
            //{
            //    Console.WriteLine($"Indice: {i} - Valor: {arrayOrigen[i]}");
            //}

        }
    }
}
