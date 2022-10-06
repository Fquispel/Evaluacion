using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CNFechas
    {
   
        private rangoFechas filtroFechas = new rangoFechas();
        public DataTable mostrarFechas()
        {
            DataTable tabla = new DataTable();
            //tabla = filtroFechas.cargarDatosFechas();
            return tabla;
        }
        
    }
}
