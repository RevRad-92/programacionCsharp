using System;

namespace Eje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");
            int materia = 0;
            int formaPago = 0;
            double total = 0;
            double poo = 2500, apWC = 2800, uX = 2400, rD = 2000, labBDR = 1500, estProb = 1500;
            bool otraMateria = true;
            bool otraCotizacion = true;


            do
            {
                Console.WriteLine("\nBienvenido, elija a qué materia desea anotarse.");

                do
                {
                    Console.WriteLine("\nMaterias:\n1. Programación Orientada a Objetos: $2500\n2. Aplicaciones Web Cliente: $2800\n3. Experiencia de Usuario: $2400\n4. Redes de Datos: $2000\n5. Laboratorio Base de Datos Relacionales: $1500\n6. Estadística y Probabilidad: $1500\n");
                    Console.Write("Elección de materia: ");
                    materia = Convert.ToInt32(Console.ReadLine());

                    switch (materia)
                    {
                        case 1:
                            total = total + poo * 5;
                            break;
                        case 2:
                            total = total + apWC * 5;
                            break;
                        case 3:
                            total = total + uX * 5;
                            break;
                        case 4:
                            total = total + rD * 5;
                            break;
                        case 5:
                            total = total + labBDR * 5;
                            break;
                        case 6:
                            total = total + estProb * 5;
                            break;

                        default:
                            Console.WriteLine("la opción de materia ingresada es inexistente");
                            break;
                    }


                    Console.WriteLine($"\nEl total acumulado actual es:${total} (sin aplicar descuentos)");
                    Console.WriteLine("Desea seleccionar otra materia?\n1. Si\n2. No");


                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        otraMateria = true;
                        Console.Clear();
                    }
                    else
                    {
                        otraMateria = false;
                    }

                } while (otraMateria);


                Console.WriteLine("\nSeleccionar forma de pago:\n1. Un pago\n2. En 5 Cuotas\n");
                Console.Write("Elección de tipo de pago: ");
                formaPago = Convert.ToInt32(Console.ReadLine());


                if (formaPago == 1)
                {
                    total = total - (total * 15 / 100);
                    Console.WriteLine("\nLa forma de pago elegida es: Un Pago. Se aplicará un 15% de descuento sobre el total.\n");
                }
                else if (formaPago == 2)
                {
                    Console.WriteLine("\nLa forma de pago elegida es: 5 cuotas.\n");
                }
                else
                {
                    Console.WriteLine("\nLa forma de pago elegida es inexistente");
                }

                Console.WriteLine($"El monto total a pagar es: ${total}");


                Console.WriteLine("\nDesea realizar otra cotización?\n1. Si\n2. No");

                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    otraCotizacion = true;
                    Console.Clear();
                }
                else
                {
                    otraCotizacion = false;
                }

            } while (otraCotizacion);

            Console.WriteLine("Muchas gracias!"); 


            Console.ReadKey();
        }
    }
}
