using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Common.cache;

namespace Presentacion
{
    public partial class DiseForm : Form
    {
        private bool EsColapzado;
        public DiseForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            CargarDataUsuario();
            if (LoginUsuarioCache.ID_ROL == Cargos.Digitador)
            {
                btnViajes.Enabled = false;
                btnMotoristas.Enabled = false;
                btnEmpresarios.Enabled = false;
                btnAutobuses.Enabled = false;
                btnLugares.Enabled = false;
            }
            if (LoginUsuarioCache.ID_ROL == Cargos.Digitador)
            {
                btnReportes.Enabled = false;
            }
            if (LoginUsuarioCache.ID_ROL == Cargos.Administrador)
            {

            }
            ColapzarUsuario.Start();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro se cerrará la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAutobuses_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAutobuses());
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 240)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 60;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 240;
                SidebarWrapper.Width = 250;
                LineaSidebar.Width = 230;
                AnimaacionSidebarBack.Show(Sidebar);
            }
        }

        private void ColapzarUsuario_Tick(object sender, EventArgs e)
        {
            if (EsColapzado)
            {
               
                PanelUsuario.Height += 10;
                if (PanelUsuario.Size == PanelUsuario.MaximumSize)
                {
                    ColapzarUsuario.Stop();
                    EsColapzado = false;
                }
            }
            else
            {
               
                PanelUsuario.Height-=10;
                if (PanelUsuario.Size == PanelUsuario.MinimumSize)
                {
                    ColapzarUsuario.Stop();
                    EsColapzado = true;
                }
            }
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            ColapzarUsuario.Start();
        }

        public void CargarDataUsuario()
        {
            lblNombre.Text = LoginUsuarioCache.NOMBRE_USUARIO ;
            lblCargo.Text = LoginUsuarioCache.ID_ROL.ToString();
            // lblcorreo.Text = LoginUsuarioCache.;

        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿está seguro se serrará esta sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
