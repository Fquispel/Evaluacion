using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CNDatos
    {
        private Datos cargar = new Datos();
        public DataTable visualizarData()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.cargarDatos();
            return tabla;
        }
    }
}
