using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OPERACION__FQL_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Contrato contrato = new Contrato();
            contrato.Show();
        }

        private void btnReporteFechas_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
