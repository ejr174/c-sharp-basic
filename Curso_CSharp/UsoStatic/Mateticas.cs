using System;
using System.Collections.Generic;
using System.Text;

namespace UsoStatic
{
    internal class Mateticas
    {
        public static double pi = 3.1416;

        // Las constante no es necesario colocarle el modificador static,
        // ya que por ser constante no se puede modificar su valor, es decir, es como si fuera static por defecto
        public const string mensajeEterno = "Atletico Nacional es el mas frende de COLOMBIA";
        public static int potenciacion(int numBase, int exponente)
        {

            int resultado = 1;

            for (int i = 0; i < exponente; i++) {

                resultado = resultado * numBase;
            }


            return resultado;
        }
    }
}
