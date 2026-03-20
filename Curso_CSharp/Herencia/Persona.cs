using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Persona
    {
        // Atributos
        private string nombres;
        private string apellidos;
        private string numId;
        private string direccion;
        private string telefono;

        // Constructor
        public Persona(string nombres, string apellidos, string numId, string direccion, string telefono)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numId = numId;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        // Métodos GET
        public string getNombres() {  return nombres; }

        public string getApellidos() { return apellidos; }

        public string getNumId() { return numId; }

        public string getDireccion() { return direccion; }

        public string getTelefono() { return telefono; }
    }
}
