using System;

namespace Ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[,] usuarios = { { "Juan", "admin" }, { "Nico", "1234" }, { "Carla", "4567" } };
            string user = "";
            string password = "";
            int contador = 0;

            Console.WriteLine(usuarios.GetLength(0));
            Console.WriteLine(usuarios.GetLength(1));

            Console.ReadKey();


            do
            {
                Console.Clear();
                Console.Write("Ingresar usuario: ");
                user = Console.ReadLine();
                Console.Write("Ingresar contraseña: ");
                password = Console.ReadLine();

                 
                if(Auth(user, password, usuarios))
                {
                    break;
                }
                contador++;

            } while (contador < 3);




        }

        static bool Auth(string user, string password, string[,] usuarios)
        {
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] == user && usuarios[i, 1] == password)
                {
                    Console.WriteLine("Acceso concedido");
                    return true;
                } 

            }

            Console.WriteLine("Accesso denegado!");
            return false;
        }

    }
}
