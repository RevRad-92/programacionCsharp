using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 - Login");

            string[,] matriz = { { "admin", "istea2022" }, { "Claudo", "1234" }, { "Karina", "5678" }, { "Nicolas", "4545" }, { "Carlos", "asdfg" } };

            //Console.WriteLine($"USUARIO:{matriz[0, 0]} PASSWORD: {matriz[0, 1]}");

            string usuario = "";
            string clave = "";
            bool autenticado = false;
            int contador = 0;


            Console.WriteLine("Login V2");

            do
            {
                usuario = "";
                clave = "";
                Console.Write("USUARIO: ");
                usuario = Console.ReadLine();
                Console.Write("PASSWORD: ");
                clave = Console.ReadLine();

                // AUTENTICAR
                autenticado = Autenticar(matriz, usuario, clave);


                contador++;


            } while (!autenticado & contador < 3);

            if (autenticado)
            {

                Console.WriteLine("Bienvenido " + usuario);
            }
            else
            {
                Console.WriteLine("Datos Incorrectos");
            }

            Console.ReadKey();

        }

        static bool Autenticar(string[,] matriz, string usuario, string clave)
        {
            bool userOk = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // i = usuario
                if (matriz[i, 0].ToLower().Equals(usuario.ToLower()))
                {
                    userOk = true;
                }

                if (userOk)
                {
                    if (matriz[i, 1].Equals(clave))
                    {
                        return true;
                    }
                    else
                    {
                        userOk = false;
                    }
                }

            }

            return false;
            
        }
    }
}
