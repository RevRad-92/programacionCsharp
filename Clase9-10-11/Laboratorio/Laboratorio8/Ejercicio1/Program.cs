using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            int[] array = { 10, 20, 5, 15, 30, 20 };
            int total = 0;
            int contador = 0;
            int mayor = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Índice: {i}, Valor: {array[i]} ");

                if (i % 2 != 0)
                {
                    Console.WriteLine($"Posición impar: {i}!");
                } 
                
                if ( array[i] == 20 )
                {
                    contador++;
                }

                if (array[i] > mayor )
                {
                    mayor = array[i];
                }
               

                total += array[i];

            }

            Console.ReadKey();

            Console.WriteLine($"Totalización del arreglo: {total}");

            Console.WriteLine($"Contador de 20: {contador}");

            Console.WriteLine($"El número mayor es {mayor}");


        }
    }
}
