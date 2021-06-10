using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.cache;
using Dominio;
using System.Diagnostics;

namespace Presentacion
{
    public partial class Lugares_Form : Form
    {
        public Lugares_Form()
        {
            InitializeComponent();
            Usuario();
            Departamento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                objLugar.Id_Lugar = int.Parse(IDLugar.Text);
                objLugar.Nombre_Lugar = comboNombre.Text;
                objLugar.Id_Depertamento = int.Parse(comboDepartamento.SelectedValue.ToString());
                objLugar.Id_Usuario_Crea = int.Parse(comboUsuario.SelectedValue.ToString());
                objLugar.Fecha_Crea = Convert.ToDateTime(fecha.Value.ToString("yyyy-MM-dd"));

                bool respuestaSQL = objLugar.InsertarLugares();

                if (respuestaSQL == true)
                {
                    MessageBox.Show("Insertado Correctamente");
                    IDLugar.Text = "";
                    comboNombre.Text = "";
                    comboDepartamento.Text = "";
                    comboUsuario.Text = "";
                    fecha.Text = "";

                }
                else
                {
                    MessageBox.Show(objLugar.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!:" + Ex.Message + "" + objLugar);

            }
        }
        private void Departamento()
        {
            //Mostrar Insertar
            LugaresModelo objLugar = new LugaresModelo();
            DataSet DatosLugares = objLugar.ConsultarDepartamento();
            comboDepartamento.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;
            comboDepartamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
            comboDepartamento.ValueMember = "ID_DEPARTAMENTO";

            //Mostrar actualizar
            cbxDepartamento.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;
            cbxDepartamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
            cbxDepartamento.ValueMember = "ID_DEPARTAMENTO";
        }
        private void Usuario()
        {
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                //Mostrar Insertar
                DataSet DatosLugares = objLugar.ConsultarUsuario();
                comboUsuario.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;
                comboUsuario.DisplayMember = "NOMBRE_USUARIO";
                comboUsuario.ValueMember = "ID_USUARIO";

                //Mostrar actualizar
                cbxUsuarioCrea.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;
                cbxUsuarioCrea.DisplayMember = "NOMBRE_USUARIO";
                cbxUsuarioCrea.ValueMember = "ID_USUARIO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objLugar.Mensaje);
            }
        }

        private void Lugares_Form_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            LugaresModelo objLugar = new LugaresModelo();
            if (string.IsNullOrEmpty(txtIdLugar.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el Id a consultar por favor");
                return;
            }
            try
            {
                DataSet DatosLugares = objLugar.ConsultarLugares(txtIdLugar.Text);
                int numregistros = DatosLugares.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existe en la tabla Autobuses este identificador");
                }
                else
                {
                    txtNombreLugar.Text = DatosLugares.Tables["TablaConsultada"].Rows[0]["NOMBRE_LUGAR"].ToString();
                    cbxDepartamento.SelectedValue = DatosLugares.Tables["TablaConsultada"].Rows[0]["ID_DEPARTAMENTO"].ToString();
                    cbxUsuarioCrea.SelectedValue = DatosLugares.Tables["TablaConsultada"].Rows[0]["ID_USUARIO_CREA"].ToString();
                    dtpFechaCrea.Text = DatosLugares.Tables["TablaConsultada"].Rows[0]["FECHA_CREA"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objLugar.Mensaje);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                objLugar.Id_Lugar = int.Parse(txtIdLugar.Text);
                objLugar.Nombre_Lugar = txtNombreLugar.Text;
                objLugar.Id_Depertamento = int.Parse(cbxDepartamento.SelectedValue.ToString());
                objLugar.Id_Usuario_Crea = int.Parse(cbxUsuarioCrea.SelectedValue.ToString());
                objLugar.Fecha_Crea = Convert.ToDateTime(dtpFechaCrea.Value.ToString("yyyy-MM-dd"));

                bool respuestaSQL = objLugar.ActualizarLugares();

                if (respuestaSQL == true)
                {
                    MessageBox.Show("Actualizado Correctamente");
                    txtIdLugar.Text = "";
                    txtNombreLugar.Text = "";
                    cbxDepartamento.Text = "";
                    cbxUsuarioCrea.Text = "";
                    dtpFechaCrea.Text = "";

                }
                else
                {
                    MessageBox.Show(objLugar.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!:" + Ex.Message + "" + objLugar);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                bool respuestaSQL = objLugar.EliminarLugares(txtIdLugar.Text);

                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos de Lugares fueron Eliminados correctamente");
                    txtIdLugar.Text = "";
                    txtNombreLugar.Text = "";
                    cbxDepartamento.Text = "";
                    cbxUsuarioCrea.Text = "";
                    dtpFechaCrea.Text = "";
                }
                else
                {
                    MessageBox.Show("error");
                    MessageBox.Show(objLugar.Mensaje);
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error!: " + Ex.Message + " " + objLugar.Mensaje);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLugares.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el idLugares por favor");
                return;
            }


            string idLugares = txtIdLugares.Text;
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                DataSet DatosLugares = objLugar.ConsultarLugares(idLugares);

                MostrarAutobuses.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objLugar.Mensaje);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            LugaresModelo objLugar = new LugaresModelo();
            try
            {
                DataSet DatosLugares = objLugar.ConsultarTodosLugares();

                MostrarAutobuses.DataSource = DatosLugares.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objLugar.Mensaje);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
