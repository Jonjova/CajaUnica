using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Dominio
{
    public class AutobusesModelo:ConexionSQL
    {
        #region -> Atributos 
        //Autobuses 
        private int ID_AUTOBUS;
        private string NUM_PLACA;
        private int NUM_ASIENTOS;
        private string MARCA;
        private string MODELO;
        private DateTime ANIO_FABRICACION;
        private int ID_EMPRESARIO;
        private int ID_USUARIO_CREA;
        private DateTime FECHA_CREACION;
        #endregion

        #region -> Propiedades
        public int id
        {
            get { return ID_AUTOBUS; }
            set { ID_AUTOBUS = value; }
        }

        public string placa
        {
            get { return NUM_PLACA; }
            set { NUM_PLACA = value; }
        }

        public int numAsientos
        {
            get { return NUM_ASIENTOS; }
            set { NUM_ASIENTOS = value; }
        }

        public string marca
        {
            get { return MARCA; }
            set { MARCA = value; }
        }

        public string modelo
        {
            get { return MODELO; }
            set { MODELO = value; }
        }

        public DateTime anioFabricacion
        {
            get { return ANIO_FABRICACION; }
            set { ANIO_FABRICACION = value; }
        }

        public int idEmpresario
        {
            get { return ID_EMPRESARIO; }
            set { ID_EMPRESARIO = value; }
        }

        public int idEUsuarioCrea
        {
            get { return ID_USUARIO_CREA; }
            set { ID_USUARIO_CREA = value; }
        }

        public DateTime fechaCrea
        {
            get { return FECHA_CREACION; }
            set { FECHA_CREACION = value; }
        }
        #endregion

        #region -> Métodos Públicos   
        //consultar todos tabla autobuses
        public DataSet ConsultarTodosAutobuses()
        {
            string cadenaSQLConsultar = "SELECT * FROM VW_AUTOBUSES";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //consulta por id tabla atubuses
        public DataSet ConsultarAutobuses(string id)
        {
            string cadenaSQLConsultar = "If Exists(Select ID_AUTOBUS From TBL_AUTOBUSES Where ID_AUTOBUS =  '" + id + "') Begin Select* From TBL_AUTOBUSES Where ID_AUTOBUS = '" + id + "' End Else Begin Select COUNT(ID_AUTOBUS) as 'NO EXISTE' From TBL_AUTOBUSES Where ID_AUTOBUS = '" + id + "' End " + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //consultar tabla empresarios
        public DataSet ConsultarEmpresarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_EMPRESARIOS";
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

        //Insertar Autobuses
        public bool InsertarAutobuses()
        {
            
            string cadenaSQLInsertar = "INSERT INTO TBL_AUTOBUSES (ID_AUTOBUS, NUM_PLACA, NUM_ASIENTOS, MARCA, MODELO,ANIO_FABRICACION,ID_EMPRESARIO,ID_USUARIO_CREA,FECHA_CREACION ) VALUES(" + this.id + ",'" + this.placa + "','" + this.numAsientos + "','" + this.marca + "','" + this.modelo + "','" + this.anioFabricacion + "','" + this.idEmpresario + "','" + this.idEUsuarioCrea + "','" + this.fechaCrea + "')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        //Obtener Autobuses por marca
        public DataSet obtenerAutobuses(string id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_AUTOBUSES WHERE ID_AUTOBUS = " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        //Actualizar Autobuses 
        public bool ActualizarAutobuses()
        {
            string cadenaSQLActualizar = "UPDATE TBL_AUTOBUSES SET NUM_PLACA = '" + this.placa + "', NUM_ASIENTOS = '" + this.numAsientos + "',MARCA='" + this.marca + "',MODELO='" + this.modelo + "',ANIO_FABRICACION='" + this.anioFabricacion + "',ID_EMPRESARIO='" + this.idEmpresario + "',ID_USUARIO_CREA='" + this.idEUsuarioCrea + "',FECHA_CREACION='" + this.fechaCrea + "' WHERE (ID_AUTOBUS= " + this.id + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }

        //Eliminar Autobuses
        public bool EliminarAutobuses(string id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_AUTOBUSES WHERE ID_AUTOBUS = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }
        #endregion
    }
}
