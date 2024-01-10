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

        private int id;
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

        public int Id { get => id; set => id = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public DataTable GetListaClientes()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_CLIENTES";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Clientes." + e.Message);
            }
        }

        public DataTable GetClientesByID()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_CLIENTE_BY_ID";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener Cliente por ID." + e.Message);
            }
        }

        public int GetCLienteIDByName(string nombre)
        {
            try
            {
                string nombreStoredProcedure = "SP_RETORNAR_CLIENTE_BY_NOMBRE";

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@nombre", nombre)
                };

                // Utiliza ExecuteScalar para obtener un solo valor
                object result = obj_capa_datos.EjecutarSPSelectScalar(nombreStoredProcedure, parametros);

                // Convierte el resultado a entero
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // Maneja el caso en el que el resultado es nulo o DBNull.Value
                    return 0; // O un valor predeterminado según tus requisitos
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de Cliente por ID." + ex.Message);
            }
        }

        public bool CrearCliente(CN_Cliente cliente)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_CLIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", cliente.Nombre),
                    new SqlParameter("@apellido", cliente.Apellido),
                    new SqlParameter("@cedula", cliente.Cedula),
                    new SqlParameter("@telefono", cliente.Telefono),
                    new SqlParameter("@direccion", cliente.Direccion),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Cliente: " + e.Message);
            }
        }

        public bool ModificarCliente(CN_Cliente cliente)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_CLIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", cliente.Nombre),
                    new SqlParameter("@apellido", cliente.Apellido),
                    new SqlParameter("@cedula", cliente.Cedula),
                    new SqlParameter("@telefono", cliente.Telefono),
                    new SqlParameter("@direccion", cliente.Direccion),
                    new SqlParameter("@id", cliente.Id)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Cliente: " + e.Message);
            }
        }

        public bool EliminarCliente(CN_Cliente cliente)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_CLIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", cliente.id),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Cliente: " + e.Message);
            }
        }
    }
}
