using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Interfaces_Desportistas
{
    internal class Deportista
    {
        // Atributos 
        protected string nombres;
        protected string posicion;
        protected int edad;
        protected int estatura;

        // Constructor
        public Deportista() { }

        public Deportista(string nombres, string posicion, int edad, int estatura)
        {
            this.nombres = nombres;
            this.posicion = posicion;
            this.edad = edad;
            this.estatura = estatura;
        }
      
    }
}
