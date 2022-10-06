using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    class Conexion
    {
        // Cadena de conexión para el acceso a la base de datos SQL Server
        private SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog =BD_CONTRATOS_[FQL]; Persist Security Info = True; User ID = sa ; Password = administrador;");
        
        // Abrir la conexión hacia la base de datos
        public SqlConnection abrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        // Cerrar la conexión 
        public SqlConnection cerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
