using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Interfaces_Desportistas
{
    internal class Basquetbolista : Deportista, IBasquetbolista
    {
        public Basquetbolista(string nombres, string posicion, int edad, int estatura) : base(nombres, posicion, edad, estatura)
        {
        }

        public bool comprobarEstatura()
        {
            if (estatura >= 190)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
