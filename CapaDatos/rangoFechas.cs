using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    

    public class rangoFechas
    {
        private Conexion conexion = new Conexion();
        SqlDataReader dr;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        //listar por fechas
        public DataTable cargarDatosFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "SP_CONTRATO";
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", fechaFin);
            comando.CommandType = CommandType.StoredProcedure;
            dr = comando.ExecuteReader();
            table.Load(dr);
            conexion.cerrarConexion();
            return table;
        }
    }
}
