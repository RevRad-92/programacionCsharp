using System;
using System.Numerics;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vectores (tipo de dato, dimension, nombre = )
            // Declaración
            
            string[] nombres = new string[4];  //estructura de 4 posiciones
            int[] numeros = new int[4]; // 0 por defecto

            // Declaración e inicialización (asignar valores)

            int[] numeros2 = { 15, 28, 21, 102 };
            int[] numeros3 = new int[10] { 42, 22, 99, 101, 88, 44, 31, 22, 11, 8};
            string[] nombres2 = { "Juan", "Pablo", "Nicolás"};

            int sumaVector = 0;
            int posicion = 0;

            int maximo = 0;
            int minimo = 0;
            int contador = 0;
            int total = 0;
            double promedio = 0;

            int largo = 20;
            int[] vector = new int[largo];
            Random rnd = new Random();

            Console.WriteLine("Vectores");

            // indice posicion 1 es 0. La máxima es n-1 (n=cantidad de posiciones)

            // Asignar valores

            nombres[0] = "Pablo";
            nombres[1] = "Juan";
            nombres[2] = "Karina";
            nombres[3] = "Jorgelina";

            numeros[0] = 0;
            numeros[1] = 1;
            numeros[2] = 2;
            numeros[3] = 3;


            //numeros[4] = 4; // no hay posicion 5 en ese array. Da error en ejecución.

            // Imprimir valor de vector:
            Console.WriteLine($"Imprimo la posición {numeros[0]} del vector nombre: {nombres[0]}");


            sumaVector = numeros[0] + numeros[1];
            Console.WriteLine($"La suma de posición 0 y 1 del vector números es {sumaVector}");

            Console.ReadKey();

            Console.WriteLine("Imprimir todo el Vector con un For");
            // Imprimir todo el Array con For
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Imprimo la posición {numeros[i]} del vector nombre: {nombres[i]}");
            }
            
            Console.ReadKey();
            Console.Clear();

            // Propiedad Length (largo)

            Console.WriteLine("Imprimir todo el Vector con un For y propiedad length");
            // Imprimir todo el Array con For
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Imprimo la posición {numeros[i]} del vector nombre: {nombres[i]}");
            }

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Imprimir todo el Vector con un While");
            // Imprimir todo el Array con For
            while (posicion < nombres.Length)
            {
                Console.WriteLine($"Imprimo la posición {numeros[posicion]} del vector nombre: {nombres[posicion]}");
                posicion++;
            }

            // minimo y máximo.


            Console.WriteLine($"Busqueda de mayor y menor");

            for (int i = 0; i < numeros3.Length; i++)
            {

                Console.Write($"{numeros3[i]}-");


            }

            maximo = numeros3[0];
            minimo = numeros3[0];

            for (int i = 0; i < numeros3.Length; i++)
            {
                if (numeros3[i] > maximo)
                {
                    maximo = numeros3[i];
                }

                if (numeros3[i] < minimo)
                {
                    minimo = numeros3[i];
                }
            }

            Console.WriteLine($"\nEl número máximo es {maximo}");
            Console.WriteLine($"El número mínimo es {minimo}");
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Cuantas veces esta el 22 en el vector");
            for (int i = 0; i < numeros3.Length; i++)
            {
                if (numeros3[i] == 22)
                {
                    contador++;
                }

                
            }

            Console.WriteLine(contador);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Totalizo el vector y saco promeio");

            for (int i = 0; i < numeros3.Length; i++)
            {
                total += numeros3[i];
                promedio = Convert.ToDouble(total) /    Convert.ToDouble(numeros3.Length);

            }
            
            Console.WriteLine($"La suma de los elementos del vector es: {total}");
            Console.WriteLine($"El promedio del vector es: {promedio}");





            // Ordenar vector
            Console.WriteLine("Ordenar Vector con función");

            

            Console.WriteLine("Vector Desordenado");

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);

                Console.Write($"{vector[i]}");

                if (i < (vector.Length - 1))
                {
                    Console.Write("-");
                }
            }

            // Menor a mayor
            Array.Sort(vector);

            

            Console.WriteLine("\nVector Ordenado - Menor a Mayor");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]}");

                if (i < (vector.Length - 1))
                {
                    Console.Write("-");
                }
            }

            

            // mayor a menor (da vuelta el vector que le des)
            Array.Reverse(vector);

            Console.WriteLine("\nVector Ordenado - Mayor a Menor");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]}");

                if (i < (vector.Length - 1))
                {
                    Console.Write("-");
                }
            }


            // Copia de un Vector

            Console.WriteLine("Copiar un vector");

            int[] origen = { 5, 15, 20, 30 };
            int[] destino = new int[origen.Length];

            Array.Copy(origen, 0, destino, 0, origen.Length);

            for (int i = 0; i < destino.Length; i++)
            {
                Console.WriteLine(destino[i]);
            }



            Console.ReadKey();
        }
    }
}
