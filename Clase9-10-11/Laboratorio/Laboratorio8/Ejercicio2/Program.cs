using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            double inflacionAnual = 0;
            double menor = 100;
            double mayor = 0;
            int menorMes = 0;
            int mayorMes = 0;

            for (int i = 0; i < inflacion.Length; i++)
            {
                inflacionAnual += inflacion[i];

                if (inflacion[i] > mayor)
                {
                    mayor = inflacion[i];
                    mayorMes = i + 1;
                }

                if (inflacion[i] < menor)
                {
                    menor = inflacion[i];
                    menorMes = i + 1;
                }
            }

            Console.WriteLine($"La inflación anual es {inflacionAnual}%");

            Console.WriteLine($"La inflación más baja es la del mes {menorMes}: {menor}%");

            Console.WriteLine($"La inflación más alta es la del mes {mayorMes}: {mayor}%");

            Console.WriteLine($"El promedio de inflación es {inflacionAnual / 12}%");

        }
    }
}
