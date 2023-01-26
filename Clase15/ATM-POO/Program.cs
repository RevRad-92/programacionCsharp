using System;

namespace ATM_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2 - ATM");

            // Instanciar clase Cliente
            Cliente cliente1 = new Cliente(); // constructor

            // cliente1.nombre = "Nico"; // solo si el atributo es público.

            // Seteo atributos
            cliente1.SetearNombre("Nicolás");
            cliente1.SetearApellido("Madeo");
            //cliente1.SetearPin("1234"); // se da por defecto en el constructor de clase Cliente.
            cliente1.SetearUsuario("30313233");

            //Console.WriteLine(cliente1.ObtenerNombre()); //obtengo

            Cliente cliente2 = new Cliente("Juan Manuel", "Fangio", "45464748", "12121"); // otro metodo constructor



            // variables 
            string dni;
            string pin;
            bool sesion = false;
            string operacion = "";
            

            Console.Write("Ingrese DNI: ");
            dni = Console.ReadLine();
            Console.Write("Ingrese el PIN: ");
            pin = Console.ReadLine();

            if (Autenticar(dni, pin, cliente1))
            {
                sesion = true;
                Console.WriteLine("Bienvenido a ATM");
                Console.Beep();

                while (sesion)
                {

                    Console.WriteLine("Seleccione la operación deseada: ");
                    Console.WriteLine("1. Informar saldo\n2. Depositar\n3. Extraer\n4. Salir");
                    operacion = Console.ReadLine();

                    Console.Clear();

                    switch (operacion)
                    {
                        case "1": // informar saldo
                           Informar(cliente1);

                            break;
                        case "2": // depositar

                            Depositar(cliente1);
                            Informar(cliente1);
                            

                            break;
                        case "3": // extraer

                            Extraer(cliente1);
                            Informar(cliente1);
                            

                            break;
                        case "4": // salir
                            sesion = false;
                            break;
                        default:
                            Console.WriteLine("Operación inexistente.");
                            break;
                    }




                }


                Console.WriteLine("Hasta la próxima!");
                Console.Beep();



            }
            else
            {
                Console.WriteLine("DNI o PIN incorrecto/s!");
                Console.Beep();
            }


            Console.ReadKey();
        }

        static bool Autenticar(string dni, string pin, Cliente cliente)
        {
            if (cliente.ObtenerUsuario().Equals(dni) & cliente.ObtenerPin().Equals(pin))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Informar(Cliente cliente) 
        {
            Console.WriteLine($"Su saldo es ${cliente.ObtenerCuenta().Informar()}");

        }

        static void Depositar(Cliente cliente)
        {

            Console.Write("Ingrese el monto: $");
            cliente.ObtenerCuenta().Depositar(Convert.ToDouble(Console.ReadLine()));

        }

        static void Extraer(Cliente cliente)
        {
            
            Console.Write($"Ingrese el monto: $");
            cliente.ObtenerCuenta().Extraer(Convert.ToDouble(Console.ReadLine()));

            // FALTA COMPROBACION DE SALDO

            //if (saldo >= importe)
            //{
            //    saldo -= importe;
            //    Console.WriteLine($"Retirando... ${importe}");

            //}
            //else
            //{
            //    Console.WriteLine("Fondos insuficientes!");

            //}



        }







    }

}
