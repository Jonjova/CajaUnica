using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using AccesoDatos;
using System.Windows.Forms;

namespace Dominio
{
    public class EmpresarioModelo:ConexionSQL
    {
        private int ID_EMPRESARIO;
        private string NOMBRE_EMPRESARIO;
        private string APELLIDO_EMPRESARIO;
        private string DIRECCION;
        private string TELEFONO;
        private int ID_USUARIO_CREA;
        private int ID_DEPARTAMENTO;
        private int ID_SEXO;
        private DateTime FECHA_CREA;       

        public int Id_empresario
        {
            get { return ID_EMPRESARIO; }
            set { ID_EMPRESARIO = value; }
        }

        public string Nombre
        {
            get { return NOMBRE_EMPRESARIO; }
            set { NOMBRE_EMPRESARIO = value; }
        }

        public string Apellido
        {
            get { return APELLIDO_EMPRESARIO; }
            set { APELLIDO_EMPRESARIO = value; }
        }

        public string direccion
        {
            get { return DIRECCION; }
            set { DIRECCION = value; }
        }

        public string telefono
        {
            get { return TELEFONO; }
            set { TELEFONO = value; }
        }

        public int id_departamento
        {
            get { return ID_DEPARTAMENTO; }
            set { ID_DEPARTAMENTO = value; }
        }

        public int id_sexo
        {
            get { return ID_SEXO; }
            set { ID_SEXO = value; }
        }
               
        public int usuarioCrea
        {
            get { return ID_USUARIO_CREA; }
            set { ID_USUARIO_CREA = value; }
        }

        public DateTime fecha
        {
            get { return FECHA_CREA; }
            set { FECHA_CREA = value; }
        }

        DateTime dateNow =DateTime.Now;

        //listar empresarios
        public DataSet ConsultarTodosEmpresarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM MOSTRAR_EMPRESARIOS;";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //search empresario
        public DataSet ConsultarEmpresario(string id)
        {
            string cadenaSQLConsultar = "select * from tbl_empresarios where id_empresario= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //insert
        public bool InsertarEmpresario()
        { 
            string cadenaSQLInsertar = "INSERT INTO TBL_EMPRESARIOS(ID_EMPRESARIO, NOMBRE_EMPRESARIO, APELLIDO_EMPRESARIO, DIRECCION, TELEFONO, ID_USUARIO_CREA, ID_DEPARTAMENTO, ID_SEXO, FECHA_CREA) VALUES(" + this.ID_EMPRESARIO + ", '" + this.NOMBRE_EMPRESARIO + "', '" + this.APELLIDO_EMPRESARIO + "', '" + this.DIRECCION + "', '" + this.TELEFONO + "', '" + this.ID_USUARIO_CREA + "', '" + this.ID_DEPARTAMENTO + "',"+this.ID_SEXO+",GETDATE())";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        
        //update
        public bool ActualizarEmpresario()
         {
           string cadenaSQLActualizar = "UPDATE TBL_EMPRESARIOS SET NOMBRE_EMPRESARIO  = '" + this.NOMBRE_EMPRESARIO + "', APELLIDO_EMPRESARIO = '" + this.APELLIDO_EMPRESARIO + "',DIRECCION='" + this.DIRECCION + "',TELEFONO='" + this.TELEFONO +"',ID_USUARIO_CREA='"+this.ID_USUARIO_CREA+"',ID_DEPARTAMENTO='"+this.ID_DEPARTAMENTO+ "',ID_SEXO='" + this.ID_SEXO + "' WHERE (ID_EMPRESARIO= " + this.Id_empresario + ")";
             bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
             return respuestaSQL;
         }

        //delete
         public bool EliminarEmpresario(string id)
         {
             string cadenaSQLEliminar = "DELETE FROM TBL_EMPRESARIOS WHERE ID_EMPRESARIO = " + id + "";
             bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
             return respuestaSQL;
         }

        //llenado de combobox
        public DataSet ConsultarDepartamen()
        {
            string cadenaSQLConsultar = "select * from TBL_DEPARTAMENTO";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarSexo()
        {
            string cadenaSQLConsultar = "select * from TBL_SEXO";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //select max id
        public DataSet LlenarIdEMPRESARIO()
        {
            string cadenaSQLConsultar = "SELECT MAX(ID_EMPRESARIO) + 1 AS ID_EMPRESARIO FROM TBL_EMPRESARIOS";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

    }
}
