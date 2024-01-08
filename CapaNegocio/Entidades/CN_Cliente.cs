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
    public class CN_Cliente : CN_Persona
    {
        private ManageSql obj_capa_datos = new ManageSql();

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

        public bool CrearCliente(CN_Cliente cliente)
        {
            try
            {
                // Nombre del stored procedure
                string nombreStoredProcedure = "SP_CREATE_ALUMNO";

                // Parámetros del stored procedure
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@cedula", cliente.cedula),
                    new SqlParameter("@nombres", cliente.nombre),
                    new SqlParameter("@apellidos", cliente.apellidos),
                    new SqlParameter("@genero", cliente.genero),
                    new SqlParameter("@fecha_nacimiento", cliente.fecha_Nacimiento),
                    new SqlParameter("@direccion", cliente.direccion),
                    new SqlParameter("@telefono", cliente.Telefono),
                    new SqlParameter("@estado", cliente.estado)
                };

                // Llama al método EjecutarSPSql
                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Candidata: " + e.Message);
            }
        }

        public DataTable GetListaAlumnos()
        {
            Console.WriteLine("entro al lista Candidatas");
            try
            {
                // Nombre del stored procedure
                string nombreStoredProcedure = "SP_OBTENER_ALUMNOS";

                // Llama al método EjecutarSPSelect
                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Candidatas." + e.Message);
            }
        }
    }
}
