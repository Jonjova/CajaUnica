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
            if (LoginUsuarioCache.NOMBRE_ROL == "Digitador") // ACCESO DIGITADOR
            {
                btnViajes.Enabled = false;
                btnMotoristas.Enabled = false;
                btnEmpresarios.Enabled = false;
                btnAutobuses.Enabled = false;
                btnLugares.Enabled = false;
                btnReportes.Enabled = false;
            }
            if (LoginUsuarioCache.NOMBRE_ROL == "Administrador") // ACCESO ADMIN
            {
                
            }
            ColapzarUsuario.Start();
        }

        // MINIMIZAR APLICACION
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // MAXIMIZAR VENTANA
        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            maximizar.Visible = true;
        }

        // MINIMIZAR VENTANA
        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        // CERRAR APLICACION
        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro se cerrará la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // CARGAR DATOS USUARIO
        public void CargarDataUsuario()
        {
            lblNombre.Text = LoginUsuarioCache.NOMBRE_CONTROL;
            lblCargo.Text = LoginUsuarioCache.NOMBRE_ROL;
        }

        // BOTON HAMBURGUESA
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

        // ABRIR FORMULARIOS EN PANEL
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

        // BOTON CONTROLES
        private void btnControles_Click(object sender, EventArgs e)
        {

        }

        // BOTON USUARIOS
        private void Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Usuarios());
        }

        // BOTON LUGARES
        private void btnLugares_Click(object sender, EventArgs e)
        {

        }

        // BOTON EMPRESARIOS
        private void btnEmpresarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empresarios());
        }

        // BOTON AUTOBUSES
        private void btnAutobuses_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAutobuses());
        }

        // BOTON MOTORISTAS
        private void btnMotoristas_Click(object sender, EventArgs e)
        {

        }

        // BOTON VIAJES
        private void btnViajes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDetalleViajes());
        }

        // BOTON EGRESOS
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Egresos());

        }

        // BOTON REPORTES
        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        // BOTON CERRAR SESION
        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro? se cerrará esta sesión", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
