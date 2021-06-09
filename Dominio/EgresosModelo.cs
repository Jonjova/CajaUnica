using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Dominio
{
    public class EgresosModelo:ConexionSQL
    {
        #region -> Atributos 
        private int ID_EGRESO;
        private int ID_AUTOBUS;
        private double PAGO_GASTOS;
        private string NOMBRE_EGRESO;
        private string OBSERVACION;
        private int ID_USUARIO_CREA;
        private DateTime FECHA_CREACION;
        #endregion

        #region -> Propiedades
        public int IdEgreso
        {
            get { return ID_EGRESO; }
            set { ID_EGRESO = value; }
        }

        public int IdAutobus
        {
            get { return ID_AUTOBUS; }
            set { ID_AUTOBUS = value; }
        }

        public double PagoGastos
        {
            get { return PAGO_GASTOS; }
            set { PAGO_GASTOS = value; }
        }

        public string NombreEgreso
        {
            get { return NOMBRE_EGRESO; }
            set { NOMBRE_EGRESO = value; }
        }

        public string Observacion
        {
            get { return OBSERVACION; }
            set { OBSERVACION = value; }
        }

        public int IdUsuarioCrea
        {
            get { return ID_USUARIO_CREA; }
            set { ID_USUARIO_CREA = value; }
        }

        public DateTime FechaCreacion
        {
            get { return FECHA_CREACION; }
            set { FECHA_CREACION = value; }
        }
        #endregion

        #region -> Métodos Públicos 
          
        public DataSet ConsultarTodosEgresos()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_EGRESOS";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //search egresos
        public DataSet ConsultarEgresos(string id)
        {
            string cadenaSQLConsultar = "select * from TBL_EGRESOS WHERE ID_EGRESO= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //insert
        public bool InsertarEgresos()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_EGRESOS(ID_EGRESO, ID_AUTOBUS, PAGO_GASTOS, NOMBRE_EGRESO, OBSERVACION, ID_USUARIO_CREA, FECHA_CREACION) VALUES(" + this.IdEgreso + ", '" + this.IdAutobus + "', '" + this.PagoGastos + "', '" + this.NombreEgreso + "', '" + this.Observacion + "', '" + this.IdUsuarioCrea + "', '" + this.FechaCreacion.ToShortDateString() + "')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        //update
        public bool ActualizarEgresos()
        {

            string cadenaSQLActualizar = "UPDATE TBL_EGRESOS SET ID_AUTOBUS  = '" + this.IdAutobus + "',PAGO_GASTOS='" + this.PagoGastos + "',NOMBRE_EGRESO='" + this.NombreEgreso + "',OBSERVACION='" + this.Observacion + "',ID_USUARIO_CREA='" + this.IdUsuarioCrea + "',FECHA_CREACION='" + this.FechaCreacion + "' WHERE (ID_EGRESO= " + this.IdEgreso + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }

        //delete
        public bool EliminarEgresos(string id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_EGRESOS WHERE ID_EGRESO = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }

        //consultar tabla Autobuses
        public DataSet ConsultarAutobuses()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_AUTOBUSES";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //consultar tabla usuarios
        public DataSet ConsultarUsuarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_USUARIOS";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        #endregion
    }
}
