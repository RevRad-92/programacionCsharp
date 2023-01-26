using System;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");

            string dni = "", pin = "", dniDB = "36686844", pinDB = "1234";
            int operation = 0;
            double saldo = 200, monto = 0;
            

            Console.Write("Ingrese el DNI: ");
            dni = Console.ReadLine();
            Console.Write("Ingrese el PIN: ");
            pin = Console.ReadLine();

            if (dni == dniDB && pin == pinDB)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a Banco ISTEA");

                Console.Write($"Seleccione la operación deseada:\n1. Extracción\n2. Depósito\n3. Consultar Saldo\n");
                Console.Write("Opción nro: ");
                operation = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (operation)
                {
                    case 1:
                        Console.Write("Monto a extraer: $");
                        monto = Convert.ToDouble(Console.ReadLine());
                        if (monto <= saldo)
                        {
                            saldo -= monto;
                            Console.WriteLine("Operación Exitosa!");
                            
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                            
                        }
                        break;

                    case 2:
                        Console.Write("Monto a depositar: $");
                        monto = Convert.ToDouble(Console.ReadLine());
                        saldo += monto;
                        Console.WriteLine("Operación Exitosa!");
                        
                        break;

                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Operación inválida");
                        break;
                }

                Console.WriteLine($"Saldo Actual: ${saldo}");

            } else
            {
                Console.WriteLine("Credenciales inválidas");
            }

            Console.WriteLine("Adios, muchas gracias!");

            Console.ReadKey();
        }
    }
}
