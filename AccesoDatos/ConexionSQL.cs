using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public abstract class ConexionSQL
    { 
        
        private string mensaje;
        SqlConnection conn;
        SqlTransaction tran;
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public readonly string conexString;
        public ConexionSQL()
        {
            //Data Source =.; Initial Catalog = USAM; Integrated Security = True
            //esta cadena la podemos generar en el explorador de servidores 
            conexString = "Data Source=BDCAJAUSAM.mssql.somee.com;Initial Catalog=BDCAJAUSAM;User ID=josuelopez200103_SQLLogin_1;Password=qnt76ppdyc;";
        }
        
        protected SqlConnection obtenerConex()
        {
            return new SqlConnection(conexString);
        }

        public DataSet ConsultarSQL(String SentenciaSQL)
        {
            try
            {
                conn = obtenerConex();
                conn.Open();
                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL, conn);
                DataSet datos = new DataSet();
                objRes.Fill(datos, "TablaConsultada");
                mensaje = "La consulta de datos fue Exitosa";
                return datos;
            }
            catch (Exception MiExc)
            {
                DataSet datos2 = new DataSet();
                mensaje = "ERROR FATALLITY: " + MiExc.Message;
                return datos2;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool EjecutarSQL(String SentenciaSQL)
        {
            try
            {
                conn = obtenerConex();
                conn.Open();
                SqlCommand miComando = new SqlCommand();
                miComando.Connection = conn;
                miComando.CommandText = SentenciaSQL;
                miComando.ExecuteNonQuery();
                mensaje = "Proceso Ejecutado con Exito";
                return true;
            }
            catch (Exception e)
            {
                mensaje = "Tenemos el siguiente Fatality: " + e.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
