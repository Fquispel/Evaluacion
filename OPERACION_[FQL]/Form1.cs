using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace OPERACION__FQL_
{
    public partial class Form1 : Form
    {
        usuarioLogin log = new usuarioLogin();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            try
            {
                //Validación de Campos Vacios
                if (txtUsuario.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Debe Ingresar Su Usuario y Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Debe Ingresar Su Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Debe Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }
                //Validar Existencia de Usuario en BD
                bool boolValUsuario = log.validarUsuario(txtUsuario.Text);

                if (boolValUsuario == false)
                {
                    MessageBox.Show("El Usuario no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }
                else
                {
                    //Validar registro de usuario en base de datos
                    bool boolLoginUsuario = log.loginUsuario(txtUsuario.Text, txtPassword.Text);

                    if (boolLoginUsuario == false)
                    {
                        MessageBox.Show("El Usuario o Contraseña no Coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido ");
                        menu.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se acceder, se encontro el siguiente error : " + ex);
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
