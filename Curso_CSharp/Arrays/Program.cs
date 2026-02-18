using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber1 = 15;
            int myNumber2 = 10;

            int[] myNumbers = new int[2];

            myNumbers[0] = myNumber1;
            myNumbers[1] = myNumber2;

            Console.WriteLine(myNumbers[1]);

            // Inicializar los valores del array directamente
            int[] otroArray = { 2312, 34234, 3434, 3434 };
            Console.WriteLine("Otro Arrya: " + otroArray[2]); 

            // Ejemplo con  un array de strings
            string[] nombreCompleto = new string[3];

            Console.Write("Ingrese el primer nombre: ");
            string primerNombre = Console.ReadLine();
            nombreCompleto[0] = primerNombre.Trim();

            Console.Write("Ingrese el primer apellido: ");
            string primerApellido = Console.ReadLine();
            nombreCompleto[1] = primerApellido.Trim();

            Console.Write("Ingrese el segundo apellido: ");
            string segundoApellido = Console.ReadLine();
            nombreCompleto[2] = segundoApellido.Trim();

            Console.WriteLine("Nombre completo: " + nombreCompleto[0] + " " + nombreCompleto[1] + " " + nombreCompleto[2]);

            // Asi podemos inicializar valores en un array
            int[] array2 = new int[3] { 0, 1, 2 };
            int[] array3 =  { 0, 1, 2 };

            // Matrices [filas, columnas]
            int[,] array4 = new int[2, 2];
            int[,] array5 = new int[,] { { 1, 2 }, { 3, 4 } };
        }
    }
}
