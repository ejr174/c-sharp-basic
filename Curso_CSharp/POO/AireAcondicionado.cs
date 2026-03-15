using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    internal class AireAcondicionado
    {
        // Atributos
        private string marca;
        private string modelo;
        private string color;
        private int voltaje;
        private int btu;
        private int temperatura;

        // Constructor
        public AireAcondicionado()
        {

        }

        public AireAcondicionado(string ma, string mo)
        {
            marca = ma;
            modelo = mo;
        }

        public AireAcondicionado(string ma, string mo, string co, int vo, int bt, int te)
        {
            marca = ma;
            modelo = mo;
            color = co;
            voltaje = vo;
            btu = bt;
            temperatura = te;
        }

        // Metodos GET y SET
        public string getMarca() { 
            return marca;
        }

        public void setMarca(string ma)
        {
            marca = ma;
        }

        public void setModelo(string mo)
        {
            modelo = mo;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setColor(string co)
        {
            color = co;
        }

        public string getColor()
        {
            return color;
        }

        public void setVoltaje(int vo)
        {
            voltaje = vo;
        }

        public int getVoltaje()
        {
            return voltaje;
        }

        public void setBtu(int bt)
        {
            btu = bt;
        }

        public int getBtu()
        {
            return btu;
        }

        public void setTemperatura(int te)
        {
            temperatura = te;
        }

        public int getTemperatura()
        {
            return temperatura;
        }


        // Metodos
        public void subirTemperatura() 
        {
            temperatura +=1;
        }

        public void bajarTemperatura() 
        {
            temperatura -= 1;
        }

        public int darTemperatura() 
        {
            return temperatura;
        }
        
    }
}
