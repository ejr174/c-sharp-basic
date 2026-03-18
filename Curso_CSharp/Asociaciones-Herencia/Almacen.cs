using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones_Herencia
{
    internal class Almacen
    {
        // Asociacion con la cls Venta
        private Venta[] venta = new Venta[2];

        // Constructor
        public Almacen()
        {
            venta = new Venta[2];
        }

        public void crearVenta(double totalVenta, Cliente clienteVenta, Fecha fechaVenta) {
            bool ventaExistente = false;

            for (int i = 0; i < venta.Length; i++)
            {

                if (venta[i] == null)
                {
                    venta[i] = new Venta(i + 1, totalVenta, clienteVenta, fechaVenta);

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
    }
}
