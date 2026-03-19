using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones_Herencia
{
    internal class Almacen
    {
        // Asociacion con la cls Venta
        private Venta[] ventas = new Venta[2];

        // Constructor
        public Almacen()
        {
            ventas = new Venta[2];
        }

        public void crearVenta(double totalVenta, Cliente clienteVenta, Fecha fechaVenta)
        {
            bool ventaExistente = false;

            for (int i = 0; i < ventas.Length; i++)
            {

                if (ventas[i] == null)
                {
                    ventas[i] = new Venta(i + 1, totalVenta, clienteVenta, fechaVenta);

                    ventaExistente = true;
                }

                break;

            }

            if (ventaExistente)
            {
                MessageBox.Show("Venta registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta. Almacen lleno.");
            }
        }

        public Venta getUltimaVenta()
        {
            Venta venta = null;

            if (ventas[0] != null)
            {
                for(int i = 0; i < ventas.Length; i++)
                {
                    if (ventas[i] == null)
                    {
                        venta = ventas[i-1];
                        break;
                    }
                }
            }

            return venta;
        }    
    }
}
