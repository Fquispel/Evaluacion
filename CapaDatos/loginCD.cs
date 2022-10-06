using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    // Clase que llama al procedimiento almacenado
    public class loginCD
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        // Validar si existe el usuario
        public bool validarUsuario(string nombreUsuario)
        {
            int result;

            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_VALIDAR_USUARIO";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@USUARIO", nombreUsuario);

                comando.Parameters.Add("@RESULTADO", SqlDbType.Decimal, 10).Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                result = Convert.ToInt32(comando.Parameters["@RESULTADO"].Value);

                if (result == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                comando.Connection.Close();
            }
        }

        // Procedimiento almacendo para acceder a la aplicacion
        public bool loginUsuario(string nombreUsuario, string passwordUsuario)
        {
            int result;
            
            comando.Connection = conexion.abrirConexion();
            try
            {               
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_LOGIN";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@USUARIO", nombreUsuario);
                comando.Parameters.AddWithValue("@PASSWORD", passwordUsuario);
                comando.Parameters.Add("@RESULTADO", SqlDbType.Decimal, 10).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                result = Convert.ToInt32(comando.Parameters["@RESULTADO"].Value);
                if (result == 0)
                    return false;
                else
                    return true;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;

            }
            finally
            {
                comando.Connection.Close();
            }
        }

    }
}
