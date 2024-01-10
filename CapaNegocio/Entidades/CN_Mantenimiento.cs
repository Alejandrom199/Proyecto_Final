using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Mantenimiento
    {
        /*private ManageSql obj_capa_datos = new ManageSql();

        private string id;
        private CN_Cliente id_cliente;
        private CN_Mecanico id_mecanico;
        private DateTime fecha;
        private CN_Vehiculo vehiculo;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private decimal totPagar;

        public CN_Mantenimiento(string codigo, string mecanico, CN_Cliente cliente, string fecha, CN_Vehiculo vehiculo, string diagnostico, string trabajosRealizados, string tipoMantenimiento, decimal totPagar)
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

        public DataTable GetListaMecanicos()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MECANICOS";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Mecanicos." + e.Message);
            }
        }*/
    }
}
