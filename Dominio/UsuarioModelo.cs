using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
namespace Dominio
{
    public class UsuarioModelo:ConexionSQL
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public bool LoginUser(string usuario, string contra)
        {
            return usuarioDAO.Login(usuario, contra);
        }

        #region -> Atributos
        private int ID_USUARIO;
        private string NOMBRE_USUARIO;
        private string CONTRASENA;
        private int ID_CONTROL;
        private int ID_ROL;
        private DateTime FECHA_CREA;
        #endregion

        #region -> Propiedades
        public int idUsuario
        {
            get { return ID_USUARIO; }
            set { ID_USUARIO = value; }
        }
        public string nombreUsuario
        {
            get { return NOMBRE_USUARIO; }
            set { NOMBRE_USUARIO = value; }
        }
        public string contra
        {
            get { return CONTRASENA; }
            set { CONTRASENA = value; }
        }
        public int idControl
        {
            get { return ID_CONTROL; }
            set { ID_CONTROL = value; }
        }
        public int idRol
        {
            get { return ID_ROL; }
            set { ID_ROL = value; }
        }
        public DateTime fechaCrea
        {
            get { return FECHA_CREA; }
            set { FECHA_CREA = value; }
        }
        #endregion

        #region -> Métodos Públicos
        //consultar todos los Usuarios
        public DataSet ConsultarTodosUsuarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM VW_USUARIOS";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        //consultar por id  
        public DataSet ConsultarUsuarios(string id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_USUARIOS WHERE ID_USUARIO = " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        //consultar tabla Control
        public DataSet ConsultarControl()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_CONTROL";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        //consultar tabla Roles
        public DataSet ConsultarRoles()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_ROLES";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        //Insertar Usuarios
        public bool InsertarUsuarios()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_USUARIOS (ID_USUARIO,NOMBRE_USUARIO,CONTRASENA,ID_CONTROL,ID_ROL,FECHA_CREA) VALUES(" + this.idUsuario + ",'" + this.nombreUsuario + "','" + this.contra + "','" + this.idControl + "','" + this.idRol + "','" + this.fechaCrea + "')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }
        //Obtener Autobuses por Usuarios
        public DataSet obtenerUsuarios(string id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_USUARIOS WHERE ID_USUARIO = " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        //Actualizar Usuarios 
        public bool ActualizarUsuarios()
        {
            string cadenaSQLActualizar = "UPDATE TBL_USUARIOS SET NOMBRE_USUARIO = '" + this.nombreUsuario + "', CONTRASENA = '" + this.contra + "',ID_CONTROL='" + this.idControl + "',ID_ROL='" + this.idRol + "',FECHA_CREA='" + this.fechaCrea  + "' WHERE (ID_USUARIO= " + this.idUsuario + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }
        //Eliminar Usuarios
        public bool EliminarAutobuses(string id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_USUARIOS WHERE ID_AUTOBUS = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }
        #endregion

    }
}
