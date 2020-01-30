using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Asociados_CA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void msgError(string msg)
        {
            lblErrorMensage.Text = " " + msg;
            lblErrorMensage.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Menu formaSiguiente = new Menu();
            this.Hide();
            formaSiguiente.Show();
            if (txtUsuario.Text != "Username")
            {
                if (txtContraseña.Text != "Password")
                {

                }
                else
                {
                    msgError("Por favor escriba su contraseña");
                }

            }
            else
            {
                msgError("Por favor escribe tu nombre");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNuevoUsuario formaSiguiente = new FrmNuevoUsuario();
            this.Hide();
            formaSiguiente.Show();
        }
    }
}
