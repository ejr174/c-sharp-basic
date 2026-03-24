using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones
{
    internal class Cliente
    {
        // Atributos
        private string nombres;
        private string apellidos;
        private string numId;
        private string celular;

        // Constructores

        public Cliente(string nombres, string apellidos, string numId, string celular)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numId = numId;
            this.celular = celular;
        }

        public Cliente()
        {
        }

        // Métodos
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NumId { get => numId; set => numId = value; }
        public string Celular { get => celular; set => celular = value; }

    }
}
