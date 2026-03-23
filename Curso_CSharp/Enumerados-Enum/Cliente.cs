using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerados_Enum
{
    internal class Cliente
    {
        // Atributos
        private string nombres;
        private string apellidos;
        private string numId;
        private string celular;
        private string tipoCliente;

        // Constructor
        public Cliente(string nombres, string apellidos, string numId, string celular, TipoCliente tc)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numId = numId;
            this.celular = celular;
            this.tipoCliente = tc.ToString();

        }

        public Cliente() { }

        // Métodos Setters y Getters
        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string NUMID
        {
            get { return numId; }
            set { numId = value; }
        }

        public string CELULAR
        {
            get { return celular; }
            set { celular = value; }
        }

        public string TIPODECLIENTE
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        public enum TipoCliente
        {
            Regular = 100,
            Premium = 500,
            VIP = 1000
        }

    }
}
