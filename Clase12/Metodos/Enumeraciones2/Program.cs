using System;

namespace Enumeraciones2
{

    public enum Materias
    {
        Matematica=1,
        Fisica,
        SociedadyEstado,
        IPC

    }

    internal class Program
    {



        static void Main(string[] args)
        {
            int materia = 0;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Materia {i}: {(Materias)i}");
            }

            Console.WriteLine();

            Console.WriteLine("Seleccione el numero de la materia: ");

            materia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Has seleccionado la materia {(Materias)materia}");

            Console.ReadKey();
           
        }
    }
}
