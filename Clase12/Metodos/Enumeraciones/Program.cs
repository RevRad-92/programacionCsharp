using System;

namespace Enumeraciones
{

    public enum Genero
    {
        femenino = 1,
        masculino = 3, 
        otro = 5
    }

    public enum EstadoCivil
    {
        soltero, // 0
        casado,  // 1
        viudo,
        separado
    }

    internal class Program
    {



        static void Main(string[] args)
        {
            int idGenero = 3;
            Genero genero1 = (Genero)idGenero; // casteo. Convierte idGenero a tipo Genero. 

            // int idGenero2 = (int)Genero.femenino; // casteo inverso

            Console.WriteLine("Enumeraciones");

            CrearPersona("Nicolás", "Madeo", genero1, EstadoCivil.casado);

            Console.ReadKey();

        }

        static void CrearPersona(string nombre, string apellido, Genero genero, EstadoCivil estadoCivil)
        {
            Console.WriteLine("Creando Persona...");
            Console.WriteLine($"{nombre} {apellido} es de género {genero} y estado civil {estadoCivil}");

        }
    }
}
