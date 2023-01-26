using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Random");
            int randomNro = 0;
            Random random = new Random(); // declaro el elemento Random.

            randomNro = random.Next(1, 101); // número aleatorio del 1 al 100 (primer numero incluido, ultimo excluido--> [1...101) )

            Console.WriteLine($"El número sorteado es: {randomNro}");
            */

            Console.Title = "Piedra, Papel o Tijera";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 30; // en pixeles
            Console.WindowWidth = 42;
            Console.Clear();

            for (int i = 0; i < 42; i++)
            {
                Console.Write("*");
            }

            Console.SetCursorPosition(0, 1); // caracter, renglon
            Console.Write("|                                        |");
            Console.SetCursorPosition(0, 2);
            Console.Write("| Bienvenido al Piedra, Papel o Tijera!  |");
            Console.SetCursorPosition(0, 3);
            Console.Write("|                                        |");
            Console.SetCursorPosition(0, 4);

            for (int i = 0; i < 42; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            /*
            Desarrollar una aplicacion de consola que me permita simular una partida Piedra, Papel o Tijera.
            
            Reglas de Negocio
            * La partida se desarrolla entre el Usuario vs La Aplicación
            * La aplicación debe permitir jugar más de una partida
            * Al no querer continuar, se tiene que mostrar las estadísitcas o resultados finales.
            */

            Console.ReadKey();
            Console.Beep();
            Console.Clear();

            string barra = "";

            for (int i = 0; i < 10; i++)
            {
                barra += "=";

                Console.Write("Cargando..." + barra);
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }


            Random random = new Random();
            int eleccionIA = 0;
            eleccionIA = random.Next(1, 4);
            int eleccionUsuario = 0;
            string jugadaUsuario = "";
            string jugadaIA = "";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Elije tu jugada:\n1.Piedra\n2.Papel\n3.Tijera");
            Console.Write("Jugada: ");
            eleccionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (eleccionUsuario)
            {
                case 1:
                    jugadaUsuario = "Piedra";
                    break;
                case 2:
                    jugadaUsuario = "Papel";
                    break;
                case 3:
                    jugadaUsuario = "Tijera";
                    break;

                default:
                    Console.WriteLine("Elección inexistente. Inténtelo de nuevo");
                    break;
            }


            Console.WriteLine($"Has elegido: {jugadaUsuario}");


            switch (eleccionIA)
            {
                case 1:
                    jugadaIA = "Piedra";
                    break;
                case 2:
                    jugadaIA = "Papel";
                    break;
                case 3:
                    jugadaIA = "Tijera";
                    break;

                default:
                    Console.WriteLine("Elección inexistente. Inténtelo de nuevo");
                    break;
            }
            Console.WriteLine($"Oponente ha elejido: {jugadaIA}");


            // evaluar resultado

            if (jugadaUsuario != jugadaIA)
            {
                if ( (jugadaUsuario == "Piedra" && jugadaIA == "Tijera") || (jugadaUsuario == "Papel" && jugadaIA == "Piedra") || (jugadaUsuario == "Tijera" && jugadaIA == "Papel") )
                {
                    Console.WriteLine("Has ganado!");
                }
                else 
                {
                    Console.WriteLine("Has perdido!");
                }

              
            } 
            else
            {
                Console.WriteLine("Empate");
                // empate. Next round
            }

            

             
      



            Console.ReadKey();
        }
    }
}
