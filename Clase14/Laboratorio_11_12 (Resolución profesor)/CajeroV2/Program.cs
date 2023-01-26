using System;

namespace CajeroV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string dniUsuario = "";
            string pinUsuario = "";
            int opcion = 0;
            double saldo = 25000;


            Console.WriteLine("Bienvenido Cliente Banco ISTEA");

            Console.WriteLine("Por favor digite su DNI");
            dniUsuario = Console.ReadLine();

            Console.WriteLine("Por favor digite su pin");
            pinUsuario = Console.ReadLine();

            if (Autenticar(dniUsuario, pinUsuario))
            {

                Console.WriteLine($"Bienvenido Cliente : {dniUsuario}");

                Console.WriteLine();

                Console.WriteLine("Por Favor digite una opción");

                Console.WriteLine("1    .Realizar un Deposito");
                Console.WriteLine("2    .Realizar una Extracción");
                Console.WriteLine("3    .Consultar su estado de cuenta");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Depositar(ref saldo);
                        Informar(ref saldo);

                        break;
                    case 2:
                        Extraer(ref saldo);
                        Informar(ref saldo);
                        break;
                    case 3:

                        Informar(ref saldo);

                        break;
                    default:


                        break;


                }









            }
            else
            {

                Console.WriteLine("Datos Incorrectos , buen dia");

            }








            Console.ReadKey();











        }


        static bool Autenticar(string dni, string pin)
        {
            if (dni == "22224444" & pin == "1234")
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        static void Informar(ref double saldo)
        {

            Console.WriteLine($"Su saldo es de : $ {Math.Round(saldo, 2)}");


        }

        static void Depositar(ref double saldo)
        {

            Console.WriteLine("Ingrese el monto a depositar");
            saldo += Convert.ToDouble(Console.ReadLine());



        }

        static void Extraer(ref double saldo)
        {

            Console.WriteLine("Ingrese el monto a extraer");
            saldo -= Convert.ToDouble(Console.ReadLine());



        }


    }







}
