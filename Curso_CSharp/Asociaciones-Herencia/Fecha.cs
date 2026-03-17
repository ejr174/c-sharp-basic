using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones_Herencia
{
    internal class Fecha
    {
        // Atributos
        private int dia;
        private int mes;
        private int anio;

        // Constructor
        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        // Metodos GET y SET    
        public int getDia()
        {
            return dia;
        }

        public void setDia(int dia) {
            this.dia = dia;
        }

        public int getMes()
        {
            return mes;
        }

        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getAnio()
        {
            return anio;
        }

        public void setAnio(int anio)
        {
            this.anio = anio;
        }
    }
}
