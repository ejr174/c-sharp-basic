using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones_Herencia
{
    internal class Cliente
    {
        // Atributos
        private string nombre;
        private string apellidos;
        private string numId;
        private string celular;

        //Constructor
        public Cliente (string nombre, string apellidos, string numId, string celular)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.numId = numId;
            this.celular = celular;
        }

        // Metodos GET y SET
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public string getNumId()
        {
            return numId;
        }

        public void setNumId( string numId)
        {
            this.numId = numId ;
        }

        public string getCelular()
        {
            return celular;
        }

        public void setCelular(string celular)
        {
            this.celular = celular;
        }
    }
}
