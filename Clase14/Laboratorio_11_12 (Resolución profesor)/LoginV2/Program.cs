using System;

namespace LoginV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //Matriz de 4x2
            string[,] matriz = { {"admin","istea2022" },{"Claudio","1234" },{"Karina","a12" },{"Pablo","425" } };

            string usuario = "";
            string clave = "";
            bool autenticado = false;
            int contador = 0;




            //Console.WriteLine($"USUARIO:{matriz[0,0]} PASSWORD : {matriz[0,1]}");

            Console.WriteLine("Bienvenidos al Login V2");

            do
            {

                Console.Write("Ingrese Usuario:");
                usuario = Console.ReadLine();
                Console.Write("Ingrese Password:");
                clave=Console.ReadLine();

                autenticado = Autenticar(matriz,usuario,clave);


                contador++;



            } while (!autenticado & contador < 3);


            if (autenticado)
            {
                Console.WriteLine("Bienvenido " + usuario);

            }
            else
            {

                Console.WriteLine("Datos Incorrectos");
            }























            Console.ReadKey();


        }





        static bool Autenticar(string[,] matriz, string usuario, string clave)
        {
            bool userOk = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i,0].ToLower().Equals(usuario.ToLower()))
                {
                    userOk = true;

                }

                if (userOk)
                {
                    if (matriz[i,1].Equals(clave))
                    {
                        return true;

                    }
                    else
                    {
                        userOk=false;
                    }



                }






            }





            return false;



        }



    }


    








}
