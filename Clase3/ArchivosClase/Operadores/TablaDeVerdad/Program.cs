using System;

namespace TablaDeVerdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verdadero = true;
            bool falso = false;

            Console.WriteLine("AND");

            Console.WriteLine($"Verdadero AND Verdadero: {verdadero & verdadero} ");
            Console.WriteLine($"Verdadero AND Falso :{verdadero & falso} ");
            Console.WriteLine($"Falso AND Verdadero :{falso & verdadero} ");
            Console.WriteLine($"Falso AND Falso :{falso & falso} ");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Or");

            Console.WriteLine($"Verdadero OR Verdadero :{verdadero | verdadero} ");
            Console.WriteLine($"Verdadero OR Falso :{verdadero | falso} ");
            Console.WriteLine($"Falso OR Verdadero :{falso | verdadero} ");
            Console.WriteLine($"Falso OR Falso :{falso | falso} ");

            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("NOR");

            Console.WriteLine($"Verdadero NOR Verdadero: {!(verdadero | verdadero)} ");
            Console.WriteLine($"Verdadero NOR Falso: {!(verdadero | falso)} ");
            Console.WriteLine($"Falso NOR Verdadero :{!(falso | verdadero)} ");
            Console.WriteLine($"Falso NOR Falso :{!(falso | falso)} ");






            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("NAND");

            Console.WriteLine($"Verdadero NAND Verdadero: {!(verdadero & verdadero)} ");
            Console.WriteLine($"Verdadero NAND Falso :{!(verdadero & falso)} ");
            Console.WriteLine($"Falso NAND Verdadero :{!(falso & verdadero)} ");
            Console.WriteLine($"Falso NAND Falso :{!(falso & falso)} ");


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("XOR");

            Console.WriteLine("Verdadero XOR Verdadero = {0}", verdadero ^ verdadero);
            Console.WriteLine("Verdadero XOR Falso = {0}", verdadero ^ falso);
            Console.WriteLine("Falso XOR Verdadero = {0}", falso ^ verdadero);
            Console.WriteLine("Falso XOR Falso = {0}", falso ^ falso);


            Console.ReadKey();
            Console.Clear();
        }
    }
}
