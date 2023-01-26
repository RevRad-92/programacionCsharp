using System;

namespace Partido_Equipos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Definir las variables: goles, equipos
            int golesA = 0, golesB = 0;
            string a = "Equipo A", b = "Equipo B";

            int probabilidad = 0;

            Random rnd = new Random();

            Console.WriteLine($"Oprime enter para iniciar el partido entre: {a} y {b}");

            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                probabilidad = rnd.Next(1,11); //10% de chance de que termine en gol

                if (probabilidad == 1 )
                {
                    Console.WriteLine($"Gol de {a}!!");
                    golesA++;
                    Console.ReadKey();
                }

                probabilidad = rnd.Next(1, 11); //10% de chance de que termine en gol

                if (probabilidad == 1)
                {
                    Console.WriteLine($"Gol de {b}!!");
                    golesB++;
                    Console.ReadKey();
                }

            }

            #region Resultados
            if (golesA > golesB )
            {
                Console.WriteLine($"Ganó {a}: {golesA} - {golesB}");
            }

            if (golesA < golesB)
            {
                Console.WriteLine($"Ganó {b}: {golesA} - {golesB}");
            }

            if (golesA == golesB)
            {
                Console.WriteLine($"Empate: {golesA} - {golesB}");
            }

            #endregion

            Console.ReadKey();



        }
    }
}
