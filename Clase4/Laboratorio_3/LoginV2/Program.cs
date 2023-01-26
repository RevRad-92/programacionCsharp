using System;

namespace LoginV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string usuario = "admin";
            string password = "Istea2022";
            int opcion = 0;
            string usuarioIngresado = "", passwordIngresado = "";



            Console.WriteLine("Bienvenido al portal de Istea");


            Console.WriteLine("Ya tienes cuenta? 1.Si - 2.No");

            Console.Write("Respuesta:");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 1)
            {

                Console.WriteLine("Ingresar el nombre de usuario para su cuenta");

                Console.Write("Usuario: ");

                usuario = Console.ReadLine();


                Console.WriteLine("Ingresar el password para su cuenta");

                Console.Write("Password: ");

                passwordIngresado = Console.ReadLine();


            }


            Console.Write("Ingrese su usuario:");

            usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese su password:");


            passwordIngresado = Console.ReadLine();



            if (usuarioIngresado == usuario && passwordIngresado == password)
            {



                Console.WriteLine($"Bienvendido/a usuario :{usuario}");



            }
            else
            {

                Console.WriteLine("Los datos ingresados son invalidos");

            }




            Console.ReadKey();




















        }
    }
}
