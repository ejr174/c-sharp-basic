using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones_Herencia
{
    internal class Venta
    {
        //Atributos
        private int numeroVenta;
        private double total;

        // Relaciones de asociación
        private Cliente cliente;
        private Fecha fecha;

        // Constructor
        public Venta(int numeroVenta, double total)
        {
            this.numeroVenta = numeroVenta;
            this.total = total;
        }

        // Metodos GET y SET
        public int getNumeroVenta()
        {
            return numeroVenta;
        }

        public void setNumeroVenta(int numeroVenta)
        {
            this.numeroVenta = numeroVenta;
        }

        public double getTotal() { 
            return total;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

        public Cliente getCliente() { 
            return cliente;
        }

        public Fecha getFecha() { 
            return fecha;
        }

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void setFecha(Fecha fecha)
        {
            this.fecha = fecha;
        }
    }
}
