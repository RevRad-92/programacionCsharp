using System;

namespace Web_Hosting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Iniciemos evaluando las variables que tengo o voy a necesitar
            // Disponemos las opciones 
            // Solicitar datos que vas necesitar
            // Desarrollo la logica 
            // Resultado final .

            string plan = "";
            int backup = 0, tasaTransferencia = 0, llamadas = 0;
            double monto = 0;


            Console.WriteLine("Bienvenidos a Cloud Services");
            Console.WriteLine("Estos son nuestros planes de servidores");

            Console.Write("A.Plan $200\nB.Plan $100\nC.Plan $70");
            Console.WriteLine();

            Console.Write("Por favor elija el plan a contratar(letra):");
            plan = Console.ReadLine().ToUpper();


            Console.WriteLine("Estos son nuestros planes de backup");

            Console.WriteLine("1.Hasta 100gb");
            Console.WriteLine("2.Mas de 100gb y menos de 200gb");
            Console.WriteLine("3.Mas de 200gb");
            Console.WriteLine();

            Console.Write("Por favor elija el plan a contratar (numero):");
            backup = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Estos son nuestras tasas de transferencia");

            Console.WriteLine("1.5gb");
            Console.WriteLine("2.10gb");
            Console.WriteLine("3.200gb");
            Console.WriteLine();

            Console.Write("Por favor elija el plan a contratar (numero):");

            tasaTransferencia = Convert.ToInt32(Console.ReadLine());


            Console.Write("Por favor indiquenos la cantidad de llamadas a soporte a contratar:");

            llamadas=Convert.ToInt32(Console.ReadLine());


            switch (plan)
            {
                case "A":
                    monto += 200; // aca directamente le sumo a lo que ya habia en monto 200

                    break;

                case "B":

                    monto = monto + 100; // aca busco monto , le sumo 100 y luego asigno el resultado a monto


                    break;
                case "C":

                    monto = 70;// Aca directamente le asigno el valor y piso lo que habia

                    break;



                default:
                    break;
            }


            switch (backup)
            {
                case 1:

                    monto += 40;

                    break;

                case 2:

                    monto += 60;
                    break;

                case 3:
                    break;

                    monto += 80;

                default:
                    break;
            }


            if (tasaTransferencia == 1)
            {

                monto += 20;


            }

            if (tasaTransferencia == 2)
            {
                monto += 40;
            }

            if (tasaTransferencia == 3)
            {

                monto += 60;

            }

            monto += llamadas*2;


            Console.WriteLine($"El monto total por su compra es : USD {monto}");

            Console.ReadKey();

        }
    }
}
