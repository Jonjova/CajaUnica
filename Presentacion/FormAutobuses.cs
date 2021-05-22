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
    public partial class FormAutobuses : Form
    {
        public FormAutobuses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDAutobuses.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el idAutobuses por favor");
                return;
            }


            string idcAutobuses = txtIDAutobuses.Text;
            AutobusesModelo ObjAutobuses = new AutobusesModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarAutobuses(idcAutobuses);

                MostrarAutobuses.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            AutobusesModelo ObjAutobuses = new AutobusesModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarTodosAutobuses();

                MostrarAutobuses.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
