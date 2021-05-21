using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConexionSQL
    {
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

    }
}
