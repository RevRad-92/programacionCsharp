using System;

namespace Busqueda_Binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteInferior = 0;
            int limiteSuperior = 100;

            Random rnd = new Random();

            int numBuscado = rnd.Next(limiteInferior, limiteSuperior + 1);

            int corte = 0;
            int contador = 0;

            bool encontrado = false;

            Console.WriteLine("Busqueda Binaria (Algoritmo)");
            Console.WriteLine($"Número buscado: {numBuscado}");
            Console.WriteLine($"Rango de números: {limiteInferior} a {limiteSuperior}");

            while (!encontrado)
            {
                corte = (limiteSuperior + limiteInferior) / 2;

                Console.WriteLine($"Corte: {corte}");

                if (corte == numBuscado)
                {
                    encontrado = true;

                }

                if (corte > numBuscado)
                {
                    limiteSuperior = corte - 1; // -1 para excluir al corte, porque el corte no es el número buscado
                }
                else
                {
                    limiteInferior = corte + 1;
                }

                contador++;
            }

            Console.WriteLine($"Se han realizado: {contador} intentos para hallar el número {numBuscado}");




            Console.ReadKey();
        }
    }
}
