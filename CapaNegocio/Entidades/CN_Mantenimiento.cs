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

        private int id;
        private int cliente;
        private int mecanico;
        private DateTime fecha;
        private string vehiculo_placa;
        private string vehiculo_marca;
        private string vehiculo_modelo;
        private string vehiculo_color;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private string servicio;
        private string repuestos;
        private float valor_repuestos;
        private float totalPagar;
        public CN_Mantenimiento()
        {
            repuestos = "n/a";
            valor_repuestos = 0;
            totalPagar = 0;
        }

        public CN_Mantenimiento(int id, int cliente, int mecanico, DateTime fecha, string vehiculo_placa, string vehiculo_marca, string vehiculo_modelo, string vehiculo_color, string diagnostico, string trabajosRealizados, string tipoMantenimiento, string servicio, string repuestos, float valor_repuestos, float totalPagar)
        {
            this.id = id;
            this.cliente = cliente;
            this.mecanico = mecanico;
            this.fecha = fecha;
            this.vehiculo_placa = vehiculo_placa;
            this.vehiculo_marca = vehiculo_marca;
            this.vehiculo_modelo = vehiculo_modelo;
            this.vehiculo_color = vehiculo_color;
            this.diagnostico = diagnostico;
            this.trabajosRealizados = trabajosRealizados;
            this.tipoMantenimiento = tipoMantenimiento;
            this.servicio = servicio;
            this.repuestos = repuestos;
            this.valor_repuestos = valor_repuestos;
            this.totalPagar = totalPagar;
        }


        public int Id { get => id; set => id = value; }
        public int Cliente { get => cliente; set =>  cliente = value; }
        public int Mecanico { get => mecanico; set => mecanico = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        

        public string Vehiculo_Placa
        {
            get { return vehiculo_placa; } set { vehiculo_placa = value;}
        }

        public string Vehiculo_Marca
        {
            get { return vehiculo_marca; } set { vehiculo_marca = value; }
        }

        public string Vehiculo_Modelo
        {
            get { return vehiculo_modelo; } set { vehiculo_modelo = value; }
        }

        public string Vehiculo_Color
        {
            get { return vehiculo_color; } set { vehiculo_color = value; }
        }


        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string TrabajosRealizados { get => trabajosRealizados; set => trabajosRealizados = value; }
        public string TipoMantenimiento { get => tipoMantenimiento; set => tipoMantenimiento = value; }
        
        public string Servicio { get => servicio; set => servicio = value; }
        public string Repuestos { get => repuestos; set =>repuestos = value; }
        public float Valor_Repuestos { get => valor_repuestos; set => valor_repuestos = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }

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
                    new SqlParameter("@id_cliente", mantenimiento.cliente),
                    new SqlParameter("@id_mecanico",mantenimiento.mecanico),
                    new SqlParameter("@fecha", mantenimiento.fecha),
                    new SqlParameter("@vehiculo_placa", mantenimiento.vehiculo_placa),
                    new SqlParameter("@vehiculo_marca", mantenimiento.vehiculo_marca),
                    new SqlParameter("@vehiculo_modelo", mantenimiento.vehiculo_modelo),
                    new SqlParameter("@vehiculo_color", mantenimiento.vehiculo_color),
                    new SqlParameter("@diagnostico", mantenimiento.diagnostico),
                    new SqlParameter("@trabajos_realizados", mantenimiento.trabajosRealizados),
                    new SqlParameter("@tipo_mantenimiento", mantenimiento.tipoMantenimiento),
                    new SqlParameter("@servicio", mantenimiento.servicio),
                    new SqlParameter("@repuestos", mantenimiento.repuestos),
                    new SqlParameter("@valor_repuestos", mantenimiento.valor_repuestos),
                    new SqlParameter("@total_pagar", mantenimiento.totalPagar)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);

            }catch(Exception ex)
            {
                throw new Exception("Error al crear Mantenimiento: " + ex.Message);
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
                    new SqlParameter("@id_cliente", mantenimiento.cliente),
                    new SqlParameter("@id_mecanico",mantenimiento.mecanico),
                    new SqlParameter("@fecha", mantenimiento.fecha),
                    new SqlParameter("@vehiculo_placa", mantenimiento.vehiculo_placa),
                    new SqlParameter("@vehiculo_marca", mantenimiento.vehiculo_marca),
                    new SqlParameter("@vehiculo_modelo", mantenimiento.vehiculo_modelo),
                    new SqlParameter("@vehiculo_color", mantenimiento.vehiculo_color),
                    new SqlParameter("@diagnostico", mantenimiento.diagnostico),
                    new SqlParameter("@trabajos_realizados", mantenimiento.trabajosRealizados),
                    new SqlParameter("@tipo_mantenimiento", mantenimiento.tipoMantenimiento),
                    new SqlParameter("@servicio", mantenimiento.servicio),
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
