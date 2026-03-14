using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    internal class AireAcondicionado
    {
        // Atributos
        public string marca;
        public string modelo;
        public string color;
        public int voltaje;
        public int btu;
        public int temperatura;

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
