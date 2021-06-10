using Dominio;
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
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();

            obtDepartamento();
            obtSexo();
            obtIDControl();
        }

        string msg = ""; // VALIDACIONES

        //Llenado combobox de empresarios 
        private void obtIDControl()
        {
            ControlesModelo objCon = new ControlesModelo();
            try
            {
                DataSet Datos = objCon.LlenarIdCONTROLES();
                txtIdControl.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
                txtIdControl.DisplayMember = "ID_CONTROL";
                txtIdControl.ValueMember = "ID_CONTROL";

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        //Llenado combobox de empresarios 
        ControlesModelo objEmp = new ControlesModelo();

        private void obtDepartamento()
        {
            ControlesModelo objEmp = new ControlesModelo();
            try
            {
                DataSet DatosEmpresarios = objEmp.ConsultarDepartamen();
                comboBox1.DataSource = DatosEmpresarios.Tables["TablaConsultada"].DefaultView;
                comboBox1.DisplayMember = "NOMBRE_DEPARTAMENTO";
                comboBox1.ValueMember = "ID_DEPARTAMENTO";

                comboBox3.DataSource = DatosEmpresarios.Tables["TablaConsultada"].DefaultView;
                comboBox3.DisplayMember = "NOMBRE_DEPARTAMENTO";
                comboBox3.ValueMember = "ID_DEPARTAMENTO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        private void obtSexo()
        {
            ControlesModelo objEmp = new ControlesModelo();
            try
            {
                DataSet Datos = objEmp.ConsultarSexo();

                comboBox2.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
                comboBox2.DisplayMember = "NOMBRE_SEXO";
                comboBox2.ValueMember = "ID_SEXO";

                comboBox4.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
                comboBox4.DisplayMember = "NOMBRE_SEXO";
                comboBox4.ValueMember = "ID_SEXO";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        // VALIDAR INSERT EMPRESARIOS
        public void validarInsertControles()
        {
            
            if (txtNombre.Text == "")
            {
                msg = msg + "\n!!! CAMPO NOMBRE REQUERIDO !!!";
            }
            if (txtApellido.Text == "")
            {
                msg = msg + "\n!!! CAMPO APELLIDO REQUERIDO !!!";
            }
            if (txtTelefono.Text == "")
            {
                msg = msg + "\n!!! CAMPO TELEFONO REQUERIDO !!!";
            }
            if (txtDireccion.Text == "")
            {
                msg = msg + "\n!!! CAMPO DIRECCIÓN REQUERIDO !!!";
            }
            MessageBox.Show(msg);
            msg = "";
        }

        // VALIDAR UPDATE EMPRESARIOS
        public void validarUpdateControles()
        {
            if (txtNom.Text == "")
            {
                msg = msg + "\n!!! CAMPO NOMBRE REQUERIDO !!!";
            }
            if (txtApe.Text == "")
            {
                msg = msg + "\n!!! CAMPO APELLIDO REQUERIDO !!!";
            }
            if (txtTel.Text == "")
            {
                msg = msg + "\n!!! CAMPO TELEFONO REQUERIDO !!!";
            }
            if (txtDir.Text == "")
            {
                msg = msg + "\n!!! CAMPO DIRECCIÓN REQUERIDO !!!";
            }
            MessageBox.Show(msg);
            msg = "";
        }

        //insert

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                objEmp.Id_control = int.Parse(txtIdControl.Text);
                objEmp.Nombre_Control = txtNombre.Text;
                objEmp.Apellido_control = txtApellido.Text;
                objEmp.Direccion = txtDireccion.Text;
                objEmp.Telefono = txtTelefono.Text;
                objEmp.departamento = int.Parse(comboBox1.SelectedValue.ToString());
                objEmp.sexo = int.Parse(comboBox2.SelectedValue.ToString());

                if (txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
                {
                    bool respuestaSQL = objEmp.Insertar();
                    MessageBox.Show("Los datos del nuevo empresario fueron insertados correctamente");
                    txtIdControl.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    obtIDControl();//select max
                }

                else
                {
                    validarInsertControles();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + objEmp.Mensaje);
            }

        }


        //listar
         private void button3_Click_1(object sender, EventArgs e)
        {
            ControlesModelo objEmp = new ControlesModelo();
            try
            {
                DataSet DatosEmpresarios = objEmp.ConsultarTodosControles();

                dataGridView1.DataSource = DatosEmpresarios.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDC.Text == "")
                {
                    MessageBox.Show("!!! ID Control REQUERIDO !!! \nIngrese un identificador");
                }
                else
                {
                    DataSet DatosEmpresario = objEmp.ConsultarControl(txtIDC.Text);
                    int numregistros = DatosEmpresario.Tables["TablaConsultada"].Rows.Count;
                    if (numregistros == 0)
                    {
                        MessageBox.Show("No existe en la tabla Empresarios este identificador");
                    }
                    else
                    {
                        txtNom.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["NOMBRE_CONTROL"].ToString();
                        txtApe.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["APELLIDO_CONTROL"].ToString();
                        txtDir.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["DIRECCION"].ToString();
                        txtTel.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["TELEFONO"].ToString();
                        comboBox3.SelectedValue = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["ID_DEPARTAMENTO"].ToString();
                        comboBox4.SelectedValue = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["ID_SEXO"].ToString();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        
        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuestaSQL = objEmp.EliminarControl(txtIDC.Text);
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del Control fueron Eliminados correctamente");
                    txtIDC.Text = "";
                    txtNom.Text = "";
                    txtApe.Text = "";
                    txtDir.Text = "";
                    txtTel.Text = "";
                }
                else
                {
                    MessageBox.Show(objEmp.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }

        }

        //update
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objEmp.Id_control = int.Parse(txtIDC.Text);
                objEmp.Nombre_Control = txtNom.Text;
                objEmp.Apellido_control = txtApe.Text;
                objEmp.Direccion = txtDir.Text;
                objEmp.Telefono = txtTel.Text;
                objEmp.departamento = int.Parse(comboBox3.SelectedValue.ToString());
                objEmp.sexo = int.Parse(comboBox4.SelectedValue.ToString());

                if (txtNom.Text != "" && txtApe.Text != "" && txtTel.Text != "" && txtDir.Text != "")
                {
                    bool respuestaSQL = objEmp.ActualizarControl();
                    MessageBox.Show("Los datos fueron actualizados correctamente");
                    txtIDC.Text = "";
                    txtNom.Text = "";
                    txtApe.Text = "";
                    txtDir.Text = "";
                    txtTel.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                }
                else
                {
                    validarUpdateControles();
                }
            }


            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String codEmp = txtIdCon.Text;
            ControlesModelo objCon = new ControlesModelo();

            if (txtIdCon.Text == "")
            {
                MessageBox.Show("!!! ID EMPRESARIO REQUERIDO !!! \nIngrese un identificador");
            }
            else
            {
                DataSet Datos = objCon.ConsultarControl(codEmp);
                dataGridView1.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
            }
        }
    }

    
}
