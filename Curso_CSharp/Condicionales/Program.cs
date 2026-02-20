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
        }
    }
}
