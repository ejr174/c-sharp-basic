using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;

            if (valor > 10)
            {
                Console.WriteLine("El valor es mayor a 10");
            }
            else if (valor == 10)
            {
                Console.WriteLine("El valor es igual a 10");
            }
            else
            {
                Console.WriteLine("El valor es menor a 10");
            }


            // Ejemplo  de condicional Switch
            Console.Write("Ingrese el dorsal del jugador: ");

            int dorsalJugador = Convert.ToInt16(Console.ReadLine());

            switch (dorsalJugador)
            {
                case 1:
                    Console.WriteLine("El jugador es el portero");
                        break;
                case 2:
                    Console.WriteLine("El jugador es defensa (Ivan Ramiro Cordoba)");
                    break;
                case 3:
                    Console.WriteLine("El jugador tambien es defensa (Yepes)");
                    break;
                default:
                    Console.WriteLine("El jugador es un delantero");
                    break;
            }
        }
    }
}
