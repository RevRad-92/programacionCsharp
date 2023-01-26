using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_POO
{
    /* Definida por:
        1) nombre
        2) atributos
        3) propiedades/comportamientos/METODOS
        */
    internal class Cuenta
    {
        // Atributos
        static int idCuenta = 0; // (privada) estado comun a todos los objetos que se creen, para que sea unico en cada objeto.
        private int nro; // unico de cada objeto que se cree
        private double saldo; // no se modifica por ref, se modifica con this.

        // Métodos (siempre tiene al menos métodos ocultos--> Constructor)

        // Constructor(es)
        public Cuenta()
        {
            this.nro = idCuenta;
            idCuenta++;
            saldo = 500;
        }

        

        public void Extraer(double saldo) // set
        {
            this.saldo -= saldo; // this.saldo es atributo saldo propio del objeto que se cree.
        }

        public void Depositar(double saldo) // set
        {
            this.saldo += saldo; // this.saldo es atributo saldo propio del objeto que se cree.
        }

        public double Informar() // getter
        {
            return this.saldo;
        }

        public double InformarNroCuenta() //getter
        {
            return this.nro;
        }



    }
}
