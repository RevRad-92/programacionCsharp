using System;

namespace WhileAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, t = 0;

            while (x <= 12)
            {

                while (y<=10)
                {
                    Console.WriteLine($"Temporada: {x} - Capitulo: {y}");
                    t++;
                    y++;
                }

                y = 1; // para volver a poner capitulos cuando se reinicia la temporada.
                x++;
            }
        
        Console.WriteLine($"Total de capítulos: {t}"); // Es la multiplicación de iteraciones entre el primer y seguno while.

        Console.ReadKey();

        }

    }
}
