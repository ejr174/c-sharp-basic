using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Cliente : Persona
    {
        // Atributos
        private int puntos;

        // Constructor
        public Cliente(string nombres, string apellidos, string numId, string direccion, string telefono, int puntos) : base(nombres, apellidos, numId, direccion, telefono)
        {
            this.puntos = puntos;
        }

        // Metodo GET y SET
        public string getPuntos() { return puntos.ToString(); }

        public void setPuntos(int puntos) { this.puntos = puntos; }

        public override void getInfo()
        {
            MessageBox.Show("Nombre: " + getNombres() + " " + getApellidos() + "\nNúmero de ID: " + getNumId() + "\nDirección: " + getDireccion() + "\nTeléfono: " + getTelefono() + "\nPuntos: " + puntos);
        }
    }
}
