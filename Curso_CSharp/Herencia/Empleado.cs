using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Empleado : Persona
    {
        // Atributos
        private double salario;

        // Constructor

        public Empleado(string nombres, string apellidos, string numId, string direccion, string telefono, double salario) : base(nombres, apellidos, numId, direccion, telefono)
        {
            this.salario = salario;
        }

        // Metodo GET y SET
        public string getSalario() { return salario.ToString(); }

        public void setSalario(double salario) { this.salario = salario; }

        public override void getInfo()
        {
            MessageBox.Show("Nombre: " + getNombres() + " " + getApellidos() + "\nNúmero de ID: " + getNumId() + "\nDirección: " + getDireccion() + "\nTeléfono: " + getTelefono() + "\nSalario: " + salario);
        }
    }
}
