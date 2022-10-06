using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
namespace OPERACION__FQL_
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

     

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CNFechas fechas = new CNFechas();            
            grdViewDatos.DataSource = fechas.mostrarFechas();
            
        }
    }
}
