using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtContra.Text != "Contraseña")
                {
                    UsuarioModelo user = new UsuarioModelo();
                    var validaLogin = user.LoginUser(txtUsuario.Text, txtContra.Text);
                    if (validaLogin == true)
                    {
                        Principal mainMenu = new Principal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecta. \n Ingrese nuevamente");
                        txtContra.Text = "Contrasena";
                        txtUsuario.Focus();

                    }
                }
                else
                {
                    msgError("Por favor ingrese Contraseña");
                }
            }
            else
            {
                msgError("Por favor ingrese Usuario");
            }
        }

        private void msgError(string msg)
        {
            labelErrorMessage.Text = msg;
            labelErrorMessage.Visible = true;
        }
        private void Logout(object sender,FormClosedEventArgs e) {
            txtContra.Text = "Contraseña";
            txtUsuario.UseSystemPasswordChar = false;
            txtUsuario.Text = "Usuario";
            labelErrorMessage.Visible = false;
            this.Show();
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.LightGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

    }
}
