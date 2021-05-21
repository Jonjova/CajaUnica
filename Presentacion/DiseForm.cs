using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class DiseForm : Form
    {
        private bool EsColapzado;
        public DiseForm()
        {
            InitializeComponent();
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
            this.Close();
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
    }
}
