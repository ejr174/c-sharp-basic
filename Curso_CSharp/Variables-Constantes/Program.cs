using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables tipo numericas (entero)
            byte num1 = 200;
            short num2 = 30000;
            int num3 = 2000000000;
            long num4 = 9000000000000000000;
            Console.WriteLine("Valor de num1: " + num1);

            // Variables tipo numericas (decimales)
            float num5 = 3.14f;
            double num6 = 3.14159265358979323846;
            decimal num7 = 3.141592653589793238462643383279m;
            Console.WriteLine("Valor de num5: " + num5);

            // Variables tipo texto
            char letra = 'A';
            string texto = "Hola, mundo!";
            Console.WriteLine("Valor de letra: " + letra);

            // Variables tipo booleano
            bool esVerdadero = true;
            bool esFalso = false;
            Console.WriteLine("Valor de esVerdadero: " + esVerdadero);

            //Conversión de tipos
            Console.Write("Ingrese un número entero:");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número ingresado es: " + valor);

            Console.ReadKey();
        }
    }
}
