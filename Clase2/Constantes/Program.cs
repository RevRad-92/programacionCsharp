using System;

namespace Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Empresa = "ISTEA";
        
            Console.WriteLine("Constantes");
            Console.WriteLine("Nombre de la empresa: {0}", Empresa);

            // empresa = "Acme"; -> error. No puede cambiarse

            Console.ReadKey();


        }
    }
}
