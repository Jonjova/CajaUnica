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
    public partial class Empresarios : Form
    {      
        EmpresarioModelo objEmp = new EmpresarioModelo();
        
        public Empresarios()
        {
            InitializeComponent();
            //métodos de llenado de combobox
            obtDepartamento();
            obtSexo();
            
        }

        //Llenado combobox de empresarios 
        private void obtDepartamento()
        {
            EmpresarioModelo objEmp = new EmpresarioModelo();
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
            EmpresarioModelo objEmp = new EmpresarioModelo();
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

        //insert
        private void button1_Click(object sender, EventArgs e)
        {
           try
            {                
                objEmp.Id_empresario = int.Parse(txtId.Text);
                objEmp.Nombre = txtNombre.Text;
                objEmp.Apellido = txtApellido.Text;
                objEmp.direccion = txtDireccion.Text;
                objEmp.telefono = txtTelefono.Text;
                objEmp.usuarioCrea = 1;
                objEmp.id_departamento = int.Parse(comboBox1.SelectedValue.ToString());
                objEmp.id_sexo = int.Parse(comboBox2.SelectedValue.ToString());

                bool respuestaSQL = objEmp.InsertarEmpresario();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo empresario fueron insertados correctamente");
                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                else
                {
                    MessageBox.Show(objEmp.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + objEmp.Mensaje);
            }
                        
        }

        //listar
        private void button3_Click(object sender, EventArgs e)
        {
            EmpresarioModelo objEmp = new EmpresarioModelo();
            try
            {
                DataSet DatosEmpresarios = objEmp.ConsultarTodosEmpresarios();

                dataGridView1.DataSource = DatosEmpresarios.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }
        }

        //consultar
        private void button2_Click(object sender, EventArgs e)
        {
            String codEmp = txtIdEMP.Text;
            EmpresarioModelo objEmp = new EmpresarioModelo();
            
            try
            {
                DataSet DatosEmpresarios = objEmp.ConsultarEmpresario(codEmp);

                dataGridView1.DataSource = DatosEmpresarios.Tables["TablaConsultada"].DefaultView;

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
                DataSet DatosEmpresario = objEmp.ConsultarEmpresario(txtIdEmpresario.Text);
                int numregistros = DatosEmpresario.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existe en la tabla Empresarios este identificador");
                }
                else
                {
                    txtNom.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["NOMBRE_EMPRESARIO"].ToString();
                    txtApe.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["APELLIDO_EMPRESARIO"].ToString();
                    txtDir.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["DIRECCION"].ToString();
                    txtTel.Text = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["TELEFONO"].ToString();
                    comboBox3.SelectedValue = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["ID_DEPARTAMENTO"].ToString();
                    comboBox4.SelectedValue = DatosEmpresario.Tables["TablaConsultada"].Rows[0]["ID_SEXO"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + objEmp.Mensaje);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                objEmp.Id_empresario = int.Parse(txtIdEmpresario.Text);
                objEmp.Nombre = txtNom.Text;
                objEmp.Apellido = txtApe.Text;
                objEmp.direccion = txtDir.Text;
                objEmp.telefono = txtTel.Text;
                objEmp.usuarioCrea = 1;
                objEmp.id_departamento = int.Parse(comboBox3.SelectedValue.ToString());
                objEmp.id_sexo = int.Parse(comboBox4.SelectedValue.ToString());
               
                bool respuestaSQL = objEmp.ActualizarEmpresario();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente");
                    txtIdEmpresario.Text = "";
                    txtNom.Text = "";
                    txtApe.Text = "";
                    txtDir.Text = "";
                    txtTel.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuestaSQL = objEmp.EliminarEmpresario(txtIdEmpresario.Text);
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del Empresario fueron Eliminados correctamente");
                    txtIdEmpresario.Text = "";
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

        private void Empresarios_Load(object sender, EventArgs e)
        {
            //id generado
            //objEmp.generarId(txtId);
        }
    }
}
