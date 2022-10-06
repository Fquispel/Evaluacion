using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos        
    {
        private Conexion conexion = new Conexion();

        SqlDataReader dr;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable cargarDatos()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "SP_ARRENDAMIENTO";
            comando.CommandType = CommandType.StoredProcedure;
            dr = comando.ExecuteReader();
            table.Load(dr);
            conexion.cerrarConexion();
            return table;
        }

    }
}
