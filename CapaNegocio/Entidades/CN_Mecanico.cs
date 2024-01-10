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
    public class CN_Mecanico : CN_Persona
    {
        private ManageSql obj_capa_datos = new ManageSql();

        private int id;
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

        public int Id { get => id; set => id = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Experiencia { get => experiencia; set => experiencia = value; }


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
        }

        public DataTable GetMecanicosByID()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MECANICO_BY_ID";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener Mecanico por ID." + e.Message);
            }
        }

        public int GetMecanicoIDByName(string nombre)
        {
            try
            {
                string nombreStoredProcedure = "SP_RETORNAR_MECANICO_BY_NOMBRE";

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
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de Cliente por ID." + ex.Message);
            }
        }
        public bool CrearMecanico(CN_Mecanico mecanico)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_MECANICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", mecanico.Nombre),
                    new SqlParameter("@apellido", mecanico.Apellido),
                    new SqlParameter("@cedula", mecanico.Cedula),
                    new SqlParameter("@especialidad", mecanico.Especialidad),
                    new SqlParameter("@experiencia", mecanico.Experiencia),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Mecanico: " + e.Message);
            }
        }

        public bool ModificarMecanico(CN_Mecanico mecanico)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_MECANICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", mecanico.Id),
                    new SqlParameter("@nombre", mecanico.Nombre),
                    new SqlParameter("@apellido", mecanico.Apellido),
                    new SqlParameter("@cedula", mecanico.Cedula),
                    new SqlParameter("@especialidad", mecanico.Especialidad),
                    new SqlParameter("@experiencia", mecanico.Experiencia)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Mecanico: " + e.Message);
            }
        }

        public bool EliminarMecanico(CN_Mecanico mecanico)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_MECANICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", mecanico.id),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Mecanico: " + e.Message);
            }
        }
    }
}
