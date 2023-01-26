using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_POO
{
    internal class Cliente
    {
        string nombre;
        string apellido;
        string usuario;
        string pin;
        Cuenta cuenta; // cliente tiene una cuenta (cuenta subclase de cliente?)

        // método constructor (oculto por defecto)
        public Cliente()
        {
            this.pin = "12345";
            this.cuenta = new Cuenta();
        }

        public Cliente(string nombre, string apellido, string usuario, string pin)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.pin = pin;
            this.cuenta = new Cuenta();
        }

        public string ObtenerNombre()
        {
            return this.nombre;
        }

        public string ObtenerApellido()
        {
            return this.apellido;
        }

        public string ObtenerUsuario()
        {
            return this.usuario;
        }

        public string ObtenerPin()
        {
            return this.pin;
        }

        public void SetearNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetearApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetearUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public void SetearPin(string pin)
        {
            this.pin = pin;
        }

        public Cuenta ObtenerCuenta()
        {
            return this.cuenta;
        }

        

    }
}
