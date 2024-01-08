using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Mecanico : CN_Persona
    {
        private string especialidad;
        private string experiencia;

        public CN_Mecanico(string nombre, string apellido, string cedula, string especialidad, string experiencia) : base(nombre, apellido, cedula)
        {
            this.especialidad = especialidad;
            this.experiencia = experiencia;
        }

        public CN_Mecanico()
        {
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }

        public string Experiencia { get => experiencia; set => experiencia = value; }
    }
}
