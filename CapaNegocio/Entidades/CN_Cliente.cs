using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Cliente : CN_Persona
    {
        private string telefono;
        private string direccion;

        public CN_Cliente(string nombre, string apellido, string cedula, string telefono, string direccion) : base(nombre, apellido, cedula)
        {
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public CN_Cliente()
        {
        }

        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
