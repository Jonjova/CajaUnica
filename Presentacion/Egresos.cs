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
    public partial class Egresos : Form
    {
        public Egresos()
        {
           
            InitializeComponent();
            autobuses();
            usuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EgresosModelo objEgr = new EgresosModelo();
           
            try
            {

                objEgr.IdEgreso = int.Parse(txtidegresos.Text);
                objEgr.IdAutobus = int.Parse(txtIdAutobuses.SelectedValue.ToString());
                objEgr.PagoGastos = double.Parse(txtPagoGastos.Text);
                objEgr.NombreEgreso = txtNombreEgresos.Text;
                objEgr.Observacion = txtObservacion.Text;
                objEgr.IdUsuarioCrea = int.Parse(txtUsuarioCrea.SelectedValue.ToString());
                objEgr.FechaCreacion = DateTime.Today;
                bool respuestaSQL = objEgr.InsertarEgresos();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo egreso fueron insertados correctamente");
                    txtidegresos.Text = "";
                    txtIdAutobuses.Text = "";
                    txtPagoGastos.Text = "";
                    txtNombreEgresos.Text = "";
                    txtObservacion.Text = "";
                    txtUsuarioCrea.Text = "";

                }
                else
                {

                    MessageBox.Show(objEgr.Mensaje);
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }

        private void btnEgresosID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EgresosID.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el Id por favor");
                return;
            }


            string idEgresos = EgresosID.Text;
            EgresosModelo objEgr = new EgresosModelo();
            try
            {
                DataSet DatosEgresos = objEgr.ConsultarEgresos(idEgresos);

                MostrarEgresos.DataSource = DatosEgresos.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {

            EgresosModelo objEgr = new EgresosModelo();
            try
            {
                DataSet DatosEgresos = objEgr.ConsultarTodosEgresos();

                MostrarEgresos.DataSource = DatosEgresos.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            EgresosModelo objEgr = new EgresosModelo();
            if (string.IsNullOrEmpty(idEgresos.Text ?? string.Empty))
            {

                MessageBox.Show("Ingrese el Id a consultar por favor");
                return;
            }

            try
            {
                DataSet DatosEgresos = objEgr.ConsultarEgresos(idEgresos.Text);
                int numregistros = DatosEgresos.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existe en la tabla Egresos este identificador");
                }
                else
                {
                    //idEgresos.Text = DatosEgresos.Tables["TablaConsultada"].Rows[0]["ID_EGRESO"].ToString();
                    idAutobuses.SelectedValue = DatosEgresos.Tables["TablaConsultada"].Rows[0]["ID_AUTOBUS"].ToString();
                    pagosGastos.Text = DatosEgresos.Tables["TablaConsultada"].Rows[0]["PAGO_GASTOS"].ToString();
                    NombreEgresos.Text = DatosEgresos.Tables["TablaConsultada"].Rows[0]["NOMBRE_EGRESO"].ToString();
                    Observacion.Text = DatosEgresos.Tables["TablaConsultada"].Rows[0]["OBSERVACION"].ToString();
                    UsuarioCrea.SelectedValue = DatosEgresos.Tables["TablaConsultada"].Rows[0]["ID_USUARIO_CREA"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EgresosModelo objEgr = new EgresosModelo();

            try
            {

                objEgr.IdEgreso = int.Parse(idEgresos.Text);
                objEgr.IdAutobus = int.Parse(idAutobuses.SelectedValue.ToString());
                objEgr.PagoGastos = double.Parse(pagosGastos.Text);
                objEgr.NombreEgreso = NombreEgresos.Text;
                objEgr.Observacion = Observacion.Text;
                objEgr.IdUsuarioCrea = int.Parse(UsuarioCrea.SelectedValue.ToString());
                //objEgr.FechaCreacion = DateTime.Today;
                bool respuestaSQL = objEgr.ActualizarEgresos();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo egreso fueron insertados correctamente");
                    idEgresos.Text = "";
                    if (idAutobuses.Text == "") { }
                    pagosGastos.Text = "";
                    NombreEgresos.Text = "";
                    Observacion.Text = "";
                    if (txtUsuarioCrea.Text == "") {}    

                }
                else
                {

                    MessageBox.Show(objEgr.Mensaje);
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EgresosModelo objEgr = new EgresosModelo();

            try
            {
                bool respuestaSQL = objEgr.EliminarEgresos(idEgresos.Text);

                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del Egreso fueron Eliminados correctamente");
                    idEgresos.Text = "";
                    if (idAutobuses.Text == "") { }
                    pagosGastos.Text = "";
                    NombreEgresos.Text = "";
                    Observacion.Text = "";
                    if (txtUsuarioCrea.Text == "") { }

                }
                else
                {

                    MessageBox.Show(objEgr.Mensaje);
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error!: " + Ex.Message + " " + objEgr.Mensaje);
            }
        }
        //Llenado combobox de usuario
        private void usuario()
        {
            EgresosModelo ObjAutobuses = new EgresosModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarUsuarios();
                //Para llenar actualizar
                UsuarioCrea.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                UsuarioCrea.DisplayMember = "NOMBRE_USUARIO";
                UsuarioCrea.ValueMember = "ID_USUARIO";
                //Para llenar insertar
                txtUsuarioCrea.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                txtUsuarioCrea.DisplayMember = "NOMBRE_USUARIO";
                txtUsuarioCrea.ValueMember = "ID_USUARIO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }
        private void autobuses()
        {
            EgresosModelo ObjAutobuses = new EgresosModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarAutobuses();
                //Para llenar actualizar
                idAutobuses.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                idAutobuses.DisplayMember = "NUM_PLACA";
                idAutobuses.ValueMember = "ID_AUTOBUS";
                //Para llenar insertar
                txtIdAutobuses.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                txtIdAutobuses.DisplayMember = "NUM_PLACA";
                txtIdAutobuses.ValueMember = "ID_AUTOBUS";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
