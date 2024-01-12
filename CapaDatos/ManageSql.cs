using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ManageSql
    {
        private ConnectionDB conn = new ConnectionDB();

        public bool EjecutarSPSql(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();

            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable EjecutarSPSelect(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public object EjecutarSPSelectScalar(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            // Utiliza ExecuteScalar para obtener un solo valor
            object result = command.ExecuteScalar();

            conn.CerrarConexion();

            return result;
        }

        public bool EjecutarSPValidarCredenciales(string storedProcedureName, SqlParameter[] parameters)
        {
            try
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedureName;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.Connection = conn.AbrirConexion();
                int count = (int)command.ExecuteScalar();

                conn.CerrarConexion();

                // Devolver true si se encontró al menos una fila
                return count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

//SELECT COUNT(*) FROM tb_Usuarios WHERE username = @Username AND clave = @Clave ";
