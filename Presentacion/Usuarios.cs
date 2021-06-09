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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            //Mostrar Control
            obtControl();
            //Mostrar Rol
            obtRol();
        }
        //Insertar nuevo usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                ObjUsuario.idUsuario = int.Parse(txtIdUsuario.Text);
                ObjUsuario.nombreUsuario = txtNombreUsuario.Text;
                ObjUsuario.contra = txtContra.Text;
                ObjUsuario.idControl = int.Parse(txtIdControl.SelectedValue.ToString());
                ObjUsuario.idRol = int.Parse(txtRol.SelectedValue.ToString());
                ObjUsuario.fechaCrea = DateTime.Today;
                bool respuestaSQL = ObjUsuario.InsertarUsuarios();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo Usuario fueron insertados correctamente");
                    txtIdUsuario.Text = "";
                    txtNombreUsuario.Text = "";
                    txtContra.Text = "";
                    txtIdControl.Text = "";
                    txtRol.Text = "";
                }
                else
                {
                    MessageBox.Show(ObjUsuario.Mensaje);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }
        //Llenado combobox de Control 
        private void obtControl()
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                DataSet DatosUsuario = ObjUsuario.ConsultarControl();
                //Para llenar actualizar
                idControl.DataSource = DatosUsuario.Tables["TablaConsultada"].DefaultView;
                idControl.DisplayMember = "NOMBRE_CONTROL";
                idControl.ValueMember = "ID_CONTROL";
                //Para llenar insertar
                txtIdControl.DataSource = DatosUsuario.Tables["TablaConsultada"].DefaultView;
                txtIdControl.DisplayMember = "NOMBRE_CONTROL";
                txtIdControl.ValueMember = "ID_CONTROL";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }
        //Llenado combobox de Rol 
        private void obtRol()
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                DataSet DatosRol = ObjUsuario.ConsultarRoles();
                //Para llenar actualizar
                idRol.DataSource = DatosRol.Tables["TablaConsultada"].DefaultView;
                idRol.DisplayMember = "NOMBRE_ROL";
                idRol.ValueMember = "ID_ROL";
                //Para llenar insertar
                txtRol.DataSource = DatosRol.Tables["TablaConsultada"].DefaultView;
                txtRol.DisplayMember = "NOMBRE_ROL";
                txtRol.ValueMember = "ID_ROL";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }
        //Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                ObjUsuario.idUsuario = int.Parse(idUsuario.Text);
                ObjUsuario.nombreUsuario = nombreUsuario.Text;
                ObjUsuario.contra = contrasena.Text;
                ObjUsuario.idControl = int.Parse(idControl.SelectedValue.ToString());
                ObjUsuario.idRol = int.Parse(idRol.SelectedValue.ToString());
                //ObjUsuario.fechaCrea = DateTime.Today;
                bool respuestaSQL = ObjUsuario.ActualizarUsuarios();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo Usuario fueron insertados correctamente");
                    idUsuario.Text = "";
                    nombreUsuario.Text = "";
                    contrasena.Text = "";
                    idControl.Text = "";
                    idRol.Text = "";
                }
                else
                {
                    MessageBox.Show(ObjUsuario.Mensaje);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            if (string.IsNullOrEmpty(idUsuario.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el Id a consultar por favor");
                return;
            }
            try
            {
                DataSet DatosUsuario = ObjUsuario.obtenerUsuarios(idUsuario.Text);
                int numregistros = DatosUsuario.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existe en la tabla Autobuses este identificador");
                }
                else
                {
                    nombreUsuario.Text = DatosUsuario.Tables["TablaConsultada"].Rows[0]["NOMBRE_USUARIO"].ToString();
                    contrasena.Text = DatosUsuario.Tables["TablaConsultada"].Rows[0]["CONTRASENA"].ToString();
                    idControl.SelectedValue = DatosUsuario.Tables["TablaConsultada"].Rows[0]["ID_CONTROL"].ToString();
                    idRol.SelectedValue = DatosUsuario.Tables["TablaConsultada"].Rows[0]["ID_ROL"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDUser.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el idUsuario por favor");
                return;
            }


            string idUsuario = txtIDUser.Text;
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                DataSet DatosUsuario = ObjUsuario.ConsultarUsuarios(idUsuario);

                MostrarUsuarios.DataSource = DatosUsuario.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            UsuarioModelo ObjUsuario = new UsuarioModelo();
            try
            {
                DataSet DatosUsuario = ObjUsuario.ConsultarTodosUsuarios();

                MostrarUsuarios.DataSource = DatosUsuario.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUsuario.Mensaje);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
