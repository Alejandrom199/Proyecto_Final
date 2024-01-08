using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Mantenimiento
    {
        private string codigo;
        private string mecanico;
        private string cliente;
        private string fecha;
        private CN_Vehiculo vehiculo;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private decimal totPagar;

        public CN_Mantenimiento(string codigo, string mecanico, string cliente, string fecha, CN_Vehiculo vehiculo, string diagnostico, string trabajosRealizados, string tipoMantenimiento, decimal totPagar)
        {
            this.codigo = codigo;
            this.mecanico = mecanico;
            this.cliente = cliente;
            this.fecha = fecha;
            this.vehiculo = vehiculo;
            this.diagnostico = diagnostico;
            this.trabajosRealizados = trabajosRealizados;
            this.tipoMantenimiento = tipoMantenimiento;
            this.totPagar = totPagar;
        }

        public CN_Mantenimiento()
        {

        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Mecanico { get => mecanico; set => mecanico = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public CN_Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string TrabajosRealizados { get => trabajosRealizados; set => trabajosRealizados = value; }
        public string TipoMantenimiento1 { get => tipoMantenimiento; set => tipoMantenimiento = value; }
        public decimal TotPagar { get => totPagar; set => totPagar = value; }
    }
}
