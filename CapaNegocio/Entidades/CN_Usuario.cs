using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Usuario
    {
        private ManageSql obj_capa_datos = new ManageSql();
        private string username;
        private string clave;

        public CN_Usuario()
        {
            username = string.Empty;
            clave = string.Empty;
        }

        public CN_Usuario(string username, string clave)
        {
            username = username;
            clave = clave;

        }

        public string Username
        {
            get { return username; } set { username = value; }
        }

        public string Clave
        {
            get { return clave; } set { clave = value; }
        }

        public bool ValidarUsuario(CN_Usuario usuario)
        {
            try
            {
                string nombreStoredProcedure = "SP_SELECT_USER";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@username", usuario.username ),
                    new SqlParameter("@clave", usuario.clave)
                };

                return obj_capa_datos.EjecutarSPValidarCredenciales(nombreStoredProcedure, parametros);
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
        }
    }
}