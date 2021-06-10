using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Dominio
{
    public class ControlesModelo:ConexionSQL
    {
        private int ID_CONTROL;
        private string NOMBRE_CONTROL;
        private string APELLIDO_CONTROL;
        private string DIRECCION;
        private string TELEFONO;
        private int ID_DEPARTAMENTO;
        private int ID_SEXO;
        private DateTime FECHA_CREA;


        public int Id_control
        {
            get { return ID_CONTROL; }
            set { ID_CONTROL = value; }
        }

        public string Nombre_Control
        {
            get { return NOMBRE_CONTROL; }
            set { NOMBRE_CONTROL = value; }
        }

        public string Apellido_control
        {
            get { return APELLIDO_CONTROL; }
            set { APELLIDO_CONTROL = value; }
        }

        public string Direccion
        {
            get { return DIRECCION; }
            set { DIRECCION = value; }
        }

        public string Telefono
        {
            get { return TELEFONO; }
            set { TELEFONO = value; }
        }

        public int departamento
        {
            get { return ID_DEPARTAMENTO; }
            set { ID_DEPARTAMENTO = value; }
        }

        public int sexo
        {
            get { return ID_SEXO; }
            set { ID_SEXO = value; }
        }


        //listar empresarios
        public DataSet ConsultarTodosControles()
        {
            string cadenaSQLConsultar = "select * from TBL_CONTROL;";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //search empresario
        public DataSet ConsultarControl(string id)
        {
            string cadenaSQLConsultar = "select * from TBL_CONTROL where ID_CONTROL= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //insert
        public bool Insertar()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_CONTROL(ID_CONTROL,NOMBRE_CONTROL,APELLIDO_CONTROL,DIRECCION,TELEFONO,ID_DEPARTAMENTO,ID_SEXO,FECHA_CREA) VALUES("+this.ID_CONTROL+",'"+this.NOMBRE_CONTROL+"','"+this.APELLIDO_CONTROL+"','"+this.DIRECCION+"','"+this.TELEFONO+"',"+this.ID_DEPARTAMENTO+","+this.ID_SEXO+",GETDATE())";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }


        //update
        public bool ActualizarControl()
         {
             string cadenaSQLActualizar = "UPDATE TBL_CONTROL SET NOMBRE_CONTROL  = '" + this.NOMBRE_CONTROL + "', APELLIDO_CONTROL = '" + this.APELLIDO_CONTROL + "',DIRECCION='" + this.DIRECCION + "',TELEFONO='" + this.TELEFONO + "',ID_DEPARTAMENTO='" + this.ID_DEPARTAMENTO + "',ID_SEXO='" + this.ID_SEXO + "' WHERE (ID_CONTROL= " + this.Id_control + ")";
             bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
             return respuestaSQL;
         }

        //delete
        public bool EliminarControl(string id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_CONTROL WHERE ID_CONTROL = " + id + "";
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
        public DataSet LlenarIdCONTROLES()
        {
            string cadenaSQLConsultar = "SELECT MAX(ID_CONTROL) + 1 AS ID_CONTROL FROM TBL_CONTROL";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
    }
}
