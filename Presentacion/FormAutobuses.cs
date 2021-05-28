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
using System.Diagnostics;

namespace Presentacion
{
    public partial class FormAutobuses : Form
    {
        public FormAutobuses()
        {
           
            InitializeComponent();
            //Mostrar combobox de empresarios
            obtEmpresarios();
            //Mostrar combobox de usuarios
            obtUsuario();
            //this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        #region -> Definición de métodos
        //consultar tabla autobuses por id
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

        //Consultar todos los datos de la tabla de autobuses 
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
            //Para cerrar Formulario hijo 
            this.Close();
        }

        //Insertar datos 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AutobusesModelo ObjBuses = new AutobusesModelo();
            try
            {
                ObjBuses.id = int.Parse(txtID.Text);
                ObjBuses.placa = txtNumPlaca.Text;
                ObjBuses.numAsientos = int.Parse(txtNumAsientos.Text);
                ObjBuses.marca = txtMarca.Text;
                ObjBuses.modelo = txtModelo.Text;
                //Si el tipo de datos es una fecha sin hora convertimos a ha fecha corta 
                ObjBuses.anioFabricacion = Convert.ToDateTime(dtpAnioFabrica.Value.ToShortDateString());
                //SelectedValue Devuelve el contenido de la columna indicada de Empresario y Usuario en este caso el id
                ObjBuses.idEmpresario = int.Parse(txtIdEmpresario.SelectedValue.ToString());
                ObjBuses.idEUsuarioCrea = int.Parse(txtIDUsuario.SelectedValue.ToString());
                ObjBuses.fechaCrea = Convert.ToDateTime(dtpFechacrea.Value.ToShortDateString());
                bool respuestaSQL = ObjBuses.InsertarAutobuses();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo Autobuses fueron insertados correctamente");
                    txtID.Text = "";
                    txtNumPlaca.Text = "";
                    txtNumAsientos.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    dtpAnioFabrica.Text = "";
                    txtIdEmpresario.Text = "";
                    txtIDUsuario.Text = "";
                    dtpFechacrea.Text = "";

                }
                else
                {
                    MessageBox.Show("error");
                    MessageBox.Show(ObjBuses.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                var trace = new StackTrace(Ex, true);
                var frame = trace.GetFrame(0);
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error!: " + Ex.Message + " " + ObjBuses.Mensaje );
            }
        }

        //Llenado combobox de empresarios 
        private void obtEmpresarios()
        {
            AutobusesModelo ObjAutobuses = new AutobusesModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarEmpresarios();
                //Para llenar actualizar
                Empresario.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                Empresario.DisplayMember = "NOMBRE_EMPRESARIO";
                Empresario.ValueMember = "ID_EMPRESARIO";
                //Para llenar insertar
                txtIDUsuario.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                txtIDUsuario.DisplayMember = "NOMBRE_EMPRESARIO";
                txtIDUsuario.ValueMember = "ID_EMPRESARIO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }

        //Llenado combobox de usuario 
        private void obtUsuario()
        {
            AutobusesModelo ObjAutobuses = new AutobusesModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.ConsultarUsuarios();
                //Para llenar actualizar
                Usuario.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                Usuario.DisplayMember = "NOMBRE_USUARIO";
                Usuario.ValueMember = "ID_USUARIO";
                //Para llenar insertar
                txtIdEmpresario.DataSource = DatosAutobuses.Tables["TablaConsultada"].DefaultView;
                txtIdEmpresario.DisplayMember = "NOMBRE_USUARIO";
                txtIdEmpresario.ValueMember = "ID_USUARIO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }
        }
        //Obtener los datos de tabla Autobuses
        private void btnObtener_Click(object sender, EventArgs e)
        {
            AutobusesModelo ObjAutobuses = new AutobusesModelo();
            try
            {
                DataSet DatosAutobuses = ObjAutobuses.obtenerAutobuses(txtIDAutobus.Text);
                int numregistros = DatosAutobuses.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existe en la tabla Autobuses este identificador");
                }
                else
                {
                    NumeroMarc.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["NUM_PLACA"].ToString();
                    NumAsientos.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["NUM_ASIENTOS"].ToString();
                    marca.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["MARCA"].ToString();
                    Modelo.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["MODELO"].ToString();
                    AnioFabrica.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["ANIO_FABRICACION"].ToString();
                    //SelectedValue Devuelve el contenido de la columna indicada de Empresario y Usuario en este caso el id
                    Empresario.SelectedValue = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["ID_EMPRESARIO"].ToString();
                    Usuario.SelectedValue = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["ID_USUARIO_CREA"].ToString();
                    Fechacrea.Text = DatosAutobuses.Tables["TablaConsultada"].Rows[0]["FECHA_CREACION"].ToString();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjAutobuses.Mensaje);
            }

        }
        //Actualizar Datos Auobuses
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AutobusesModelo ObjBuses = new AutobusesModelo();
            try
            {
                ObjBuses.id = int.Parse(txtIDAutobus.Text);
                ObjBuses.placa = NumeroMarc.Text;
                ObjBuses.numAsientos = int.Parse(NumAsientos.Text);
                ObjBuses.marca = marca.Text;
                ObjBuses.modelo = Modelo.Text;
                ObjBuses.anioFabricacion = Convert.ToDateTime(AnioFabrica.Value.ToShortDateString());
                ObjBuses.idEmpresario = int.Parse(Empresario.SelectedValue.ToString());
                ObjBuses.idEUsuarioCrea = int.Parse(Usuario.SelectedValue.ToString());
                ObjBuses.fechaCrea = Convert.ToDateTime(Fechacrea.Value.ToShortDateString());
                bool respuestaSQL = ObjBuses.ActualizarAutobuses();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente");
                    txtIDAutobus.Text = "";
                    NumeroMarc.Text = "";
                    NumAsientos.Text = "";
                    marca.Text = "";
                    Modelo.Text = "";
                    AnioFabrica.Text = "";
                    //Condicionamos el elemento al limpiar porque agrega un valor por defecto
                    if (Empresario.Text == "") { }
                    if (Usuario.Text == "") { }
                    Fechacrea.Text = "";
                }
                else
                {
                    MessageBox.Show("error");
                    MessageBox.Show(ObjBuses.Mensaje);
                }
            }
            catch (Exception Ex)
            {
              
                MessageBox.Show("Error!: " + Ex.Message + " " + ObjBuses.Mensaje);
            }
        }
        //Eliminar datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AutobusesModelo ObjBuses = new AutobusesModelo();
            try
            {
                bool respuestaSQL = ObjBuses.EliminarAutobuses(txtIDAutobus.Text);
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos de autobuses fueron Eliminados correctamente");
                    txtIDAutobus.Text = "";
                    NumeroMarc.Text = "";
                    NumAsientos.Text = "";
                    marca.Text = "";
                    Modelo.Text = "";
                    AnioFabrica.Text = "";
                    Empresario.Text = "";
                    Usuario.Text = "";
                    Fechacrea.Text = "";
                }
                else
                {
                    MessageBox.Show("error");
                    MessageBox.Show(ObjBuses.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                
                MessageBox.Show("Error!: " + Ex.Message + " " + ObjBuses.Mensaje );
            }
        }
        #endregion
    }
}
