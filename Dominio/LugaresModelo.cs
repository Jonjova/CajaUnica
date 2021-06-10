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
    public class LugaresModelo: ConexionSQL
    {
        private int ID_LUGAR;
        private string NOMBRE_LUGAR;
        private int ID_DEPARTAMENTO;
        private int ID_USUARIO_CREA;
        private DateTime FECHA_CREA;

        public int Id_Lugar
        {
            get { return ID_LUGAR; }
            set { ID_LUGAR = value; }
        }

        public string Nombre_Lugar
        {
            get { return NOMBRE_LUGAR; }
            set { NOMBRE_LUGAR = value; }
        }

        public int Id_Depertamento
        {
            get { return ID_DEPARTAMENTO; }
            set { ID_DEPARTAMENTO = value; }
        }

        public int Id_Usuario_Crea
        {
            get { return ID_USUARIO_CREA; }
            set { ID_USUARIO_CREA = value; }
        }

        public DateTime Fecha_Crea
        {
            get { return FECHA_CREA; }
            set { FECHA_CREA = value; }
        }
        public DataSet ConsultarTodosLugares()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_LUGARES";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarLugares(string id)
        {
            string cadenaSQLConsultar = "select * from tbl_lugares where id_lugar= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //insert
        public bool InsertarLugares()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_LUGARES (ID_LUGAR, NOMBRE_LUGAR, ID_DEPARTAMENTO, ID_USUARIO_CREA, FECHA_CREA) VALUES(" + this.Id_Lugar + ",'" + this.Nombre_Lugar + "','" + this.Id_Depertamento + "','" + this.Id_Usuario_Crea + "','" + this.Fecha_Crea + "')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }


        //update
        public bool ActualizarLugares()
        {
            string cadenaSQLActualizar = "UPDATE TBL_LUGARES SET NOMBRE_LUGAR  = '" + this.Nombre_Lugar +"'ID_DEPARTAMENTO'"+ this.Id_Depertamento + "', ID_USUARIO_CREA = '" + this.Id_Usuario_Crea + "',FECHA_CREA='" + this.Fecha_Crea + "' WHERE (ID_LUGAR= " + this.Id_Lugar + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }

        //delete
        public bool EliminarLugares(string id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_LUGARES WHERE ID_LUGAR = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }

        //llenado de combobox
        public DataSet ConsultarUsuario()
        {
            string cadenaSQLConsultar = "select * from TBL_USUARIOS";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarDepartamento()
        {
            string cadenaSQLConsultar = "select * from TBL_DEPARTAMENTO";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
    }

}
