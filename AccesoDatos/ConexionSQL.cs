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
        public string Mensaje;
        public readonly string conexString;
        public ConexionSQL()
        {
            //esta cadena la podemos generar en el explorador de servidores 
            conexString = "Data Source=.;Initial Catalog=BDCAJA;Integrated Security=True";
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

    }
}
