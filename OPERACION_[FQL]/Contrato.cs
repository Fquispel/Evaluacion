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
    public partial class Contrato : Form
    {

        
        public Contrato()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
            
            Close();
        }
        private void ViewAllData()
        {

            
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            CNDatos objeto = new CNDatos();
            grdViewDatos.DataSource = objeto.visualizarData();

        }
    }
}
