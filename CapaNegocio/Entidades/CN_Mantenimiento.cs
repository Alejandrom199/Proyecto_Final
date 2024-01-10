using CapaDatos;
using Microsoft.Data.SqlClient;
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
        private ManageSql obj_capa_datos = new ManageSql();

        private string id;
        private CN_Cliente id_cliente;
        private CN_Mecanico id_mecanico;
        private DateTime fecha;
        private CN_Vehiculo vehiculo;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private string repuestos;
        private decimal valor_repuestos;
        private decimal totalPagar;

        public CN_Mantenimiento(string id, CN_Cliente id_cliente, CN_Mecanico id_mecanico, DateTime fecha, CN_Vehiculo vehiculo, string diagnostico, string trabajosRealizados, string tipoMantenimiento, string repuestos, decimal valor_repuestos, decimal totalPagar)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.id_mecanico = id_mecanico;
            this.fecha = fecha;
            this.vehiculo = vehiculo;
            this.diagnostico = diagnostico;
            this.trabajosRealizados = trabajosRealizados;
            this.tipoMantenimiento = tipoMantenimiento;
            this.repuestos = repuestos;
            this.valor_repuestos = valor_repuestos;
            this.totalPagar = totalPagar;
        }

        public CN_Mantenimiento()
        {

        }

        public string Id { get => id; set => id = value; }
        public CN_Cliente Id_Cliente { get => id_cliente; set =>  id_cliente = value; }
        public CN_Mecanico Id_Mecanico { get => id_mecanico; set => id_mecanico = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public CN_Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string TrabajosRealizados { get => trabajosRealizados; set => trabajosRealizados = value; }
        public string TipoMantenimiento { get => tipoMantenimiento; set => tipoMantenimiento = value; }
        public string Repuestos { get => repuestos; set =>repuestos = value; }
        public decimal Valor_Repuestos { get => valor_repuestos; set => valor_repuestos = value; }
        public decimal TotalPagar { get => totalPagar; set => totalPagar = value; }

        public DataTable GetListaMantenimientos()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MANTENIMIENTOS";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Mantenimientos." + e.Message);
            }
        }

        public bool CrearMantenimiento(CN_Mantenimiento mantenimiento)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_MANTENIMIENTOS";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_cliente", mantenimiento.id_cliente),
                    new SqlParameter("@id_mecanico",mantenimiento.id_mecanico),
                    new SqlParameter("@fecha", mantenimiento.fecha),
                    new SqlParameter("@vehiculo_placa", mantenimiento.Vehiculo.Placa),
                    new SqlParameter("@vehiculo_marca", mantenimiento.Vehiculo.Marca),
                    new SqlParameter("@vehiculo_modelo", mantenimiento.Vehiculo.Modelo),
                    new SqlParameter("@vehiculo_color", mantenimiento.Vehiculo.Color),
                    new SqlParameter("@diagnostico", mantenimiento.diagnostico),
                    new SqlParameter("@trabajos_realizados", mantenimiento.trabajosRealizados),
                    new SqlParameter("@tipo_mantenimiento", mantenimiento.tipoMantenimiento),
                    new SqlParameter("@repuestos", mantenimiento.repuestos),
                    new SqlParameter("@valor_repuestos", mantenimiento.valor_repuestos),
                    new SqlParameter("@total_pagar", mantenimiento.totalPagar)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Mecanico: " + e.Message);
            }
        }

        public bool ModificaMantenimiento(CN_Mantenimiento mantenimiento)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_MANTENIMIENTOS";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", mantenimiento.id),
                    new SqlParameter("@id_cliente", mantenimiento.id_cliente),
                    new SqlParameter("@id_mecanico",mantenimiento.id_mecanico),
                    new SqlParameter("@fecha", mantenimiento.fecha),
                    new SqlParameter("@vehiculo_placa", mantenimiento.Vehiculo.Placa),
                    new SqlParameter("@vehiculo_marca", mantenimiento.Vehiculo.Marca),
                    new SqlParameter("@vehiculo_modelo", mantenimiento.Vehiculo.Modelo),
                    new SqlParameter("@vehiculo_color", mantenimiento.Vehiculo.Color),
                    new SqlParameter("@diagnostico", mantenimiento.diagnostico),
                    new SqlParameter("@trabajos_realizados", mantenimiento.trabajosRealizados),
                    new SqlParameter("@tipo_mantenimiento", mantenimiento.tipoMantenimiento),
                    new SqlParameter("@repuestos", mantenimiento.repuestos),
                    new SqlParameter("@valor_repuestos", mantenimiento.valor_repuestos),
                    new SqlParameter("@total_pagar", mantenimiento.totalPagar)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Mantenimiento: " + e.Message);
            }
        }

        public bool EliminarMantenimiento(CN_Mantenimiento mantenimiento)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_MANTENIMIENTOS";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", mantenimiento.id),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Mantenimiento: " + e.Message);
            }
        }
    }
}
