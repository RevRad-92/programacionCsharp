using System;
using System.ComponentModel;

namespace Laboratorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 3");

            // Ejercicio 1
            #region Ejercicio 1
            //Console.WriteLine("Ejercicio 1");
            //int state = 0;
            //string user = "", pass = "", userDB = "nico", passDB = "admin123";
            

            //Console.WriteLine("X-System Login");
            //Console.WriteLine("1.Estoy Registrado!");
            //Console.WriteLine("2.Registrarme");
            //Console.Write("Elección: ");
            //state = Convert.ToInt32(Console.ReadLine());

            //switch (state)
            //{
            //    case 1:
            //        // Iniciar sesión
            //        Console.WriteLine("Ingrese sus credenciales: ");
            //        Console.Write("Usuario: ");
            //        user = Console.ReadLine();
            //        Console.Write("Contraseña: ");
            //        pass = Console.ReadLine();

            //        if ( user == userDB && pass == passDB )
            //        {
            //            Console.WriteLine(".");
            //            Console.Beep();
            //            Console.WriteLine(".");
            //            Console.Beep();
            //            Console.WriteLine(".");
            //            Console.Beep();
            //            Console.WriteLine($"Hola {user}, bienvenido a X-System!");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Usuario y/o contraseña no válido/s");
            //            Console.Beep();
            //            goto case 1;
            //        }

            //    case 2:
            //        // Solicitar datos registro
            //        Console.WriteLine("Por favor ingrese los datos solicitados: ");
            //        Console.Write("Nombre de usuario: ");
            //        userDB = Console.ReadLine();
            //        Console.Write("Contraseña: ");
            //        passDB = Console.ReadLine();
            //        goto case 1;


            //    default:
            //        Console.WriteLine("Opción ingresada no válida");
            //        Console.Beep();
            //        Console.ReadKey();
            //        break;
            //}


            //Console.Beep();
            //Console.ReadKey(); 
            #endregion

            // Ejercicio 2
            #region Ejercicio 2
            Console.WriteLine("Ejercicio 2");

            string plan = "", backUp = "", limite = "";
            int planA = 200, planB = 100, planC = 70;
            int backUp1 = 40, backUp2 = 60, backUp3 = 80;
            int lim5G = 20, lim10G = 40, lim20G = 60;
            int precio = 0;
            int consulta = 2, cantConsulta = 0;

            Console.WriteLine("Cotización de Plan");

            // Selección de plan
            Console.WriteLine("Seleccione el plan: ");
            //Console.WriteLine("1.Plan A: $200");
            //Console.WriteLine("2.Plan B: $100");
            //Console.WriteLine("3.Plan C: $70");
            Console.Write("1.Plan A: $200\n2.Plan b: $100\n3.Plan C: $70\n");
            Console.Write("Selección: ");
            plan = Console.ReadLine();

            switch (plan)
            {
                case "1":
                    precio = planA;
                    break;
                case "2":
                    precio = planB;
                    break;
                case "3":
                    precio = planC;
                    break;
                default:
                    Console.WriteLine("Plan inexistente");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine($"Subtotal acumulado: ${precio}");

            // Selección de Back Up
            Console.WriteLine("Seleccione el Back Up: ");
            Console.WriteLine("1. 100G: $40");
            Console.WriteLine("2. 101G-200G: $60");
            Console.WriteLine("3. +200G: $80");
            Console.Write("Selección: ");
            backUp = Console.ReadLine();

            switch (backUp)
            {
                case "1":
                    precio += backUp1;
                    break;
                case "2":
                    precio += backUp2;
                    break;
                case "3":
                    precio += backUp3;
                    break;
                default:
                    Console.WriteLine("BackUp inexistente");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine($"Subtotal acumulado: ${precio}");

            // Selección de Límite
            Console.WriteLine("Seleccione el Límite: ");
            Console.WriteLine("1. 5G: $20");
            Console.WriteLine("2. 10G: $40");
            Console.WriteLine("3. 20G: $60");
            Console.Write("Selección: ");
            limite = Console.ReadLine();

            switch (limite)
            {
                case "1":
                    precio += lim5G;
                    break;
                case "2":
                    precio += lim10G;
                    break;
                case "3":
                    precio += lim20G;
                    break;
                default:
                    Console.WriteLine("Límite inexistente");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine($"Subtotal acumulado: ${precio}");

            // Selección cantidad de consultas teléfonicas
            Console.WriteLine("Ingrese cantidad de consultas telefónicas ($2 c/u)");
            Console.Write("Cantidad: ");
            cantConsulta = Convert.ToInt32(Console.ReadLine());

            if (cantConsulta > 0)
            {
                consulta *= cantConsulta;
                precio += consulta;
            }

            Console.WriteLine($"Precio final: ${precio}");

            Console.ReadKey();
            #endregion

        }
    }
}
