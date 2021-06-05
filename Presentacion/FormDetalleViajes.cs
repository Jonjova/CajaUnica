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
using System.Globalization;

namespace Presentacion
{
    public partial class FormDetalleViajes : Form
    {
        public FormDetalleViajes()
        {
            InitializeComponent();
            LlenarComboInsert();
        }

        string msg = ""; // MENSAJE PARA LAS VALIDACIONES DE LOS CAMPOS
        DetalleViajesModelo objViaje = new DetalleViajesModelo(); // OBJETO DEL MODELO

        /******************** DATASETS PARA LLENAR CONTROLES ********************/
        DataSet sqlDataSet = new DataSet(); // CARGAR DATOS PARA ACTUALIZAR Y LLENAR TABLA
        DataSet sqlDataSetDestino = new DataSet(); // COMBOBOX LUGAR DESTINO
        DataSet sqlDataSetOrigen = new DataSet(); // COMBOBOX LUGAR ORIGEN
        DataSet sqlDataSetMotorista = new DataSet(); // COMBOBOX MOTORISTA ASIGNADO
        DataSet sqlDataSetAutobus = new DataSet(); // COMBOBOX AUTOBUS ASIGNADO

        /******************** LLENAR COMBOBOX ********************/
        #region -> METODOS COMBOBOX

        // COMBOBOX INSERTAR
        private void LlenarComboInsert()
        {
            sqlDataSetDestino = objViaje.LlenarLugares();
            comboDestino.DataSource = sqlDataSetDestino.Tables["TablaConsultada"].DefaultView;
            comboDestino.DisplayMember = "NOMBRE_LUGAR";
            comboDestino.ValueMember = "ID_LUGAR";
            //comboDestino.Items.Insert(0, "Seleccionar...");

            sqlDataSetOrigen = objViaje.LlenarLugares();
            comboOrigen.DataSource = sqlDataSetOrigen.Tables["TablaConsultada"].DefaultView;
            comboOrigen.DisplayMember = "NOMBRE_LUGAR";
            comboOrigen.ValueMember = "ID_LUGAR";

            sqlDataSetMotorista = objViaje.LlenarMotorista();
            comboMotorista.DataSource = sqlDataSetMotorista.Tables["TablaConsultada"].DefaultView;
            comboMotorista.DisplayMember = "MOTORISTA";
            comboMotorista.ValueMember = "ID_MOTORISTA";

            sqlDataSetAutobus = objViaje.LlenarAutobus();
            comboAutobus.DataSource = sqlDataSetAutobus.Tables["TablaConsultada"].DefaultView;
            comboAutobus.DisplayMember = "AUTOBUS";
            comboAutobus.ValueMember = "ID_AUTOBUS";

            sqlDataSet = objViaje.LlenarID();
            comboIDViaje.DataSource = sqlDataSet.Tables["TablaConsultada"].DefaultView;
            comboIDViaje.DisplayMember = "ID_VIAJE";
            comboIDViaje.ValueMember = "ID_VIAJE";

            //comboIDViaje.Visible = false;
            numericTarifaUp.Text = "0,00";
            numericTarifaUp.ReadOnly = true;
            numericPasajerosUp.ReadOnly = true;
        }

        // COMBOBOX ACTUALIZAR
        private void LlenarComboUpdate()
        {
            sqlDataSetDestino = objViaje.LlenarLugares();
            comboDestinoUp.DataSource = sqlDataSetDestino.Tables["TablaConsultada"].DefaultView;
            comboDestinoUp.DisplayMember = "NOMBRE_LUGAR";
            comboDestinoUp.ValueMember = "ID_LUGAR";

            sqlDataSetOrigen = objViaje.LlenarLugares();
            comboOrigenUp.DataSource = sqlDataSetOrigen.Tables["TablaConsultada"].DefaultView;
            comboOrigenUp.DisplayMember = "NOMBRE_LUGAR";
            comboOrigenUp.ValueMember = "ID_LUGAR";

            sqlDataSetMotorista = objViaje.LlenarMotorista();
            comboMotoristaUp.DataSource = sqlDataSetMotorista.Tables["TablaConsultada"].DefaultView;
            comboMotoristaUp.DisplayMember = "MOTORISTA";
            comboMotoristaUp.ValueMember = "ID_MOTORISTA";

            sqlDataSetAutobus = objViaje.LlenarAutobus();
            comboAutobusUp.DataSource = sqlDataSetAutobus.Tables["TablaConsultada"].DefaultView;
            comboAutobusUp.DisplayMember = "AUTOBUS";
            comboAutobusUp.ValueMember = "ID_AUTOBUS";
        }

        #endregion
        /******************** FIN LLENAR COMBOBOX ********************/

        /******************** VALIDACION DE CAMPOS ********************/
        #region -> VALIDACIONES

        // VALIDAR INSERT
        public void validarInsert()
        {
            if (numericTarifa.Value <= 0 || numericTarifa.Text == "")
            {
                msg = msg + "!!! TARIFA REQUERIDA !!! \nIngrese el costo de la tarifa del viaje\n";
            }
            if (numericPasajeros.Value <= 0 || numericPasajeros.Text == "")
            {
                msg = msg + "\n!!! CANTIDAD DE PASAJEROS REQUERIDO !!! \nIngrese la cantidad de pasajeros del viaje\n";
            }
            if (txtObservacion.Text == "")
            {
                msg = msg + "\n!!! OBSERVACION REQUERIDA !!! \nEscriba una observacion (percances durante el viaje, etc.) \nSi no hay observacion puede escribir: Ninguna";
            }
            MessageBox.Show(msg);
            msg = "";
        }

        // VALIDAR UPDATE
        public void validarUpdate()
        {
            if (numericIDViaje.Value == 0 || numericIDViaje.Text == "")
            {
                msg = msg + "!!! ID VIAJE REQUERIDO !!! \nIngrese un identificador\n";
            }
            if (numericPasajerosUp.Value <= 0 || numericPasajerosUp.Text == "")
            {
                msg = msg + "\n!!! CANTIDAD DE PASAJEROS REQUERIDO !!! \nIngrese la cantidad de pasajeros del viaje\n";
            }
            if (comboDestinoUp.Text == "")
            {
                msg = msg + "\n!!! LUGAR DE DESTINO REQUERIDO !!! \nSeleccione el lugar de destino del viaje\n";
            }
            if (comboOrigenUp.Text == "")
            {
                msg = msg + "\n!!! LUGAR DE ORIGEN REQUERIDO !!! \nSeleccione el lugar de origen del viaje\n";
            }
            if (comboMotoristaUp.Text == "")
            {
                msg = msg + "\n!!! MOTORISTA REQUERIDO !!! \nSeleccione un motorista para el viaje\n";
            }
            if (comboAutobusUp.Text == "")
            {
                msg = msg + "\n!!! AUTOBUS REQUERIDO !!! \nSeleccione un autobus para el viaje\n";
            }
            if (txtObservacionUp.Text == "")
            {
                msg = msg + "\n!!! OBSERVACION REQUERIDA !!! \nEscriba una observacion (percances durante el viaje, etc.) \nSi no hay observacion puede escribir: Ninguna";
            }
            MessageBox.Show(msg);
            msg = "";
        }

        #endregion
        /******************** FIN VALIDACION DE CAMPOS ********************/

        /******************** FORMULARIO DE INSERTAR ********************/
        #region -> METODOS PARA INSERTAR FORMULARIO

        // VALOR DE INGRESO DEL VIAJE ONCHANGE(TEXTBOX TARIFA)
        private void numericTarifa_ValueChanged(object sender, EventArgs e)
        {
            decimal tarifa = numericTarifa.Value;
            int pasajeros = int.Parse(numericPasajeros.Text);
            txtIngreso.Text = (tarifa * pasajeros).ToString();
        }

        // VALOR DE INGRESO DEL VIAJE ONCHANGE(TEXTBOX PASAJEROS)
        private void numericPasajeros_ValueChanged(object sender, EventArgs e)
        {
            decimal tarifa = numericTarifa.Value;
            int pasajeros = int.Parse(numericPasajeros.Text);
            txtIngreso.Text = (tarifa * pasajeros).ToString();
        }

        // BOTON GUARDAR
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                objViaje.ID_VIAJES = Convert.ToInt32(comboIDViaje.Text);
                objViaje.LUGAR_DESTINO = Convert.ToInt32(comboDestino.SelectedValue);
                objViaje.LUGAR_ORIGEN = Convert.ToInt32(comboOrigen.SelectedValue);
                objViaje.FECHA_ENTRADA = DateTime.Parse(pickerEntrada.Text);
                objViaje.FECHA_SALIDA = DateTime.Parse(pickerSalida.Text);
                objViaje.ID_MOTORISTA = Convert.ToInt32(comboMotorista.SelectedValue);
                objViaje.ID_AUTOBUS = Convert.ToInt32(comboAutobus.SelectedValue);
                objViaje.NUM_PASAJEROS = Convert.ToInt32(numericPasajeros.Text);
                objViaje.TARIFA_PASAJE = numericTarifa.Value;
                objViaje.INGRESO_VIAJE = decimal.Parse(txtIngreso.Text);
                objViaje.OBSERVACION = txtObservacion.Text;
                objViaje.ID_USUARIO_CREA = LoginUsuarioCache.ID_USUARIO;
                objViaje.FECHA_CREA = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                sqlDataSet = objViaje.InsertarViaje();

                if (sqlDataSet != null)
                {
                    MessageBox.Show("Los datos del viaje fueron insertados correctamente");
                    numericTarifa.Text = "0,00";
                    numericPasajeros.Text = "0";
                    txtIngreso.Text = "";
                    txtObservacion.Text = "";
                    LlenarComboInsert(); // CARGAR COMBOBOX
                }
                else
                {
                    MessageBox.Show(objViaje.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                validarInsert();
                MessageBox.Show("Error!: " + Ex.Message + " " + objViaje.Mensaje);
                Console.WriteLine("ERROR +++++++++++++++++++++++++ " + txtIngreso.Text + Ex);
            }
        }
        // FIN BOTON GUARDAR

        #endregion
        /******************** FIN FORMULARIO DE INSERTAR ********************/

        /******************** FORMULARIO DE ACTUALIZAR ********************/
        #region -> METODOS PARA ACTUALIZAR FORMULARIO

        // BOTON CONSULTAR VIAJE(CARGAR DATOS POR ID)
        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataSet = objViaje.ConsultarPorID(numericIDViaje.Text);

                int numRegistros = sqlDataSet.Tables["TablaConsultada"].Rows.Count;
                if (numRegistros == 0)
                {
                    MessageBox.Show("!!! ATENCION !!! \nEste identificador no existe en la tabla viajes");
                }
                else
                {
                    LlenarComboUpdate();
                    numericTarifaUp.ReadOnly = false;
                    numericPasajerosUp.ReadOnly = false;

                    comboDestinoUp.SelectedValue = sqlDataSet.Tables["TablaConsultada"].Rows[0]["LUGAR_DESTINO"].ToString();
                    comboOrigenUp.SelectedValue = sqlDataSet.Tables["TablaConsultada"].Rows[0]["LUGAR_ORIGEN"].ToString();
                    pickerEntradaUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["FECHA_ENTRADA"].ToString();
                    pickerSalidaUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["FECHA_SALIDA"].ToString();
                    comboMotoristaUp.SelectedValue = sqlDataSet.Tables["TablaConsultada"].Rows[0]["ID_MOTORISTA"].ToString();
                    comboAutobusUp.SelectedValue = sqlDataSet.Tables["TablaConsultada"].Rows[0]["ID_AUTOBUS"].ToString();
                    numericPasajerosUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["NUM_PASAJEROS"].ToString();
                    numericTarifaUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["TARIFA_PASAJE"].ToString();
                    txtIngresoUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["INGRESO_VIAJE"].ToString();
                    txtObservacionUp.Text = sqlDataSet.Tables["TablaConsultada"].Rows[0]["OBSERVACION"].ToString();

                    decimal ingreso = Decimal.Round(Convert.ToDecimal(txtIngresoUp.Text), 2); // REDONDEAR A DOS DECIMALES TEXTBOX INGRESO
                    txtIngresoUp.Text = ingreso.ToString().Replace(",", ","); // REEMPLAZAR COMA POR PUNTO TEXTBOX INGRESO
                }
            }
            catch (Exception Ex)
            {
                if (numericIDViaje.Text == "")
                {
                    MessageBox.Show("!!! ID VIAJE REQUERIDO !!! \nIngrese un identificador");
                }
                else
                {
                    MessageBox.Show("Fatality!: " + Ex.Message + " " + objViaje.Mensaje);
                }

            }
        }
        // FIN CONSULTAR POR ID

        // VALOR DE INGRESO DEL VIAJE ONCHANGE(TEXTBOX TARIFA)
        private void numericTarifaUp_ValueChanged(object sender, EventArgs e)
        {
            decimal tarifa = numericTarifaUp.Value;
            int pasajeros = int.Parse(numericPasajerosUp.Text);
            txtIngresoUp.Text = (tarifa * pasajeros).ToString();
        }

        // VALOR DE INGRESO DEL VIAJE ONCHANGE(TEXTBOX PASAJEROS)
        private void numericPasajerosUp_ValueChanged(object sender, EventArgs e)
        {
            decimal tarifa = numericTarifaUp.Value;
            int pasajeros = int.Parse(numericPasajerosUp.Text);
            txtIngresoUp.Text = (tarifa * pasajeros).ToString();
        }

        // BOTON ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objViaje.ID_VIAJES = Convert.ToInt32(numericIDViaje.Text);
                objViaje.LUGAR_DESTINO = Convert.ToInt32(comboDestinoUp.SelectedValue);
                objViaje.LUGAR_ORIGEN = Convert.ToInt32(comboOrigenUp.SelectedValue);
                objViaje.FECHA_ENTRADA = DateTime.Parse(pickerEntradaUp.Text);
                objViaje.FECHA_SALIDA = DateTime.Parse(pickerSalidaUp.Text);
                objViaje.ID_MOTORISTA = Convert.ToInt32(comboMotoristaUp.SelectedValue);
                objViaje.ID_AUTOBUS = Convert.ToInt32(comboAutobusUp.SelectedValue);
                objViaje.NUM_PASAJEROS = Convert.ToInt32(numericPasajerosUp.Text);
                objViaje.TARIFA_PASAJE = numericTarifaUp.Value;
                objViaje.INGRESO_VIAJE = decimal.Parse(txtIngresoUp.Text);
                objViaje.OBSERVACION = txtObservacionUp.Text;

                sqlDataSet = objViaje.ActualizarViaje();
                if (sqlDataSet != null)
                {
                    MessageBox.Show("Los datos del viaje fueron actualizados correctamente");
                    numericIDViaje.Text = "";
                    comboDestinoUp.DataSource = null;
                    comboOrigenUp.DataSource = null;
                    comboMotoristaUp.DataSource = null;
                    comboAutobusUp.DataSource = null;
                    numericPasajerosUp.Text = "0";
                    numericPasajerosUp.ReadOnly = true;
                    numericTarifaUp.Text = "0.00";
                    numericTarifaUp.ReadOnly = true;
                    txtIngresoUp.Text = "";
                    txtObservacionUp.Text = "";
                }
                else
                {
                    MessageBox.Show(objViaje.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                validarUpdate();
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objViaje.Mensaje);
                Console.WriteLine("ERROR ++++++++++++++++++++++++++ " + Ex);
            }
        }
        // FIN BOTON ACTUALIZAR

        #endregion
        /******************** FIN FORMULARIO DE ACTUALIZAR ********************/

        /******************** LLENAR TABLA ********************/
        // VER POR ID
        private void btnVerViaje_Click(object sender, EventArgs e)
        {
            if (numericConsultarID.Text == "")
            {
                MessageBox.Show("!!! ID VIAJE REQUERIDO !!! \nIngrese un identificador");
            }
            else
            {
                sqlDataSet = objViaje.MostrarViaje(numericConsultarID.Text);
                gridViajes.DataSource = sqlDataSet.Tables["TablaConsultada"].DefaultView;
            }
        }

        // VER TODOS
        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            sqlDataSet = objViaje.MostrarViajes();
            gridViajes.DataSource = sqlDataSet.Tables["TablaConsultada"].DefaultView;
        }
        /******************** FIN LLENAR TABLA ********************/

        // CERRAR FORMULARIO
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
