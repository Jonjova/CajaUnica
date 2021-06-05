using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AccesoDatos;
using System.Globalization;

namespace Dominio
{
    public class DetalleViajesModelo : ConexionSQL
    {
        // MAPEO
        public int ID_VIAJES { get; set; }
        public int LUGAR_DESTINO { get; set; }
        public int LUGAR_ORIGEN { get; set; }
        public DateTime FECHA_ENTRADA { get; set; }
        public DateTime FECHA_SALIDA { get; set; }
        public int ID_MOTORISTA { get; set; }
        public int ID_AUTOBUS { get; set; }
        public int NUM_PASAJEROS { get; set; }
        public decimal TARIFA_PASAJE { get; set; }
        public decimal INGRESO_VIAJE { get; set; }
        public string OBSERVACION { get; set; }
        public int ID_USUARIO_CREA { get; set; }
        public DateTime FECHA_CREA { get; set; }
        // FIN MAPEO

        // VARIABLES
        string sql;
        DataSet sqlDataSet = new DataSet();
        CultureInfo cultura = new CultureInfo("en-US"); // FORMATO DECIMAL

        // INSERTAR
        public DataSet InsertarViaje()
        {
            sql =
                "SET DATEFORMAT DMY INSERT INTO DET_VIAJES VALUES("
                + "'" + this.ID_VIAJES + "',"
                + "'" + this.LUGAR_DESTINO + "',"
                + "'" + this.LUGAR_ORIGEN + "',"
                + "'" + this.FECHA_ENTRADA + "',"
                + "'" + this.FECHA_SALIDA + "',"
                + "'" + this.ID_MOTORISTA + "',"
                + "'" + this.ID_AUTOBUS + "',"
                + "'" + this.NUM_PASAJEROS + "',"
                + "'" + this.TARIFA_PASAJE.ToString(cultura) + "',"
                + "'" + this.INGRESO_VIAJE.ToString(cultura) + "',"
                + "'" + this.OBSERVACION + "',"
                + "'" + this.ID_USUARIO_CREA + "',"
                + "'" + this.FECHA_CREA + "')";
            sqlDataSet = ConsultarSQL(sql);
            Console.WriteLine("CONSULTA:  " + sql);
            return sqlDataSet;
        }

        // CONSULTAR POR ID
        public DataSet ConsultarPorID(string IDViaje)
        {
            sql = "SELECT * FROM DET_VIAJES WHERE ID_VIAJES = " + IDViaje;
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        // ACTUALIZAR
        public DataSet ActualizarViaje()
        {
            sql =
                "SET DATEFORMAT DMY UPDATE DET_VIAJES SET "
                + "LUGAR_DESTINO = '" + this.LUGAR_DESTINO + "', "
                + "LUGAR_ORIGEN = '" + this.LUGAR_ORIGEN + "', "
                + "FECHA_ENTRADA = '" + this.FECHA_ENTRADA + "', "
                + "FECHA_SALIDA = '" + this.FECHA_SALIDA + "', "
                + "ID_MOTORISTA = '" + this.ID_MOTORISTA + "', "
                + "ID_AUTOBUS = '" + this.ID_AUTOBUS + "', "
                + "NUM_PASAJEROS = '" + this.NUM_PASAJEROS + "', "
                + "TARIFA_PASAJE = '" + this.TARIFA_PASAJE.ToString(cultura) + "', "
                + "INGRESO_VIAJE = '" + this.INGRESO_VIAJE.ToString(cultura) + "', "
                + "OBSERVACION = '" + this.OBSERVACION + "' "
                + "WHERE ID_VIAJES = " + this.ID_VIAJES;
            sqlDataSet = ConsultarSQL(sql);
            Console.WriteLine("CONSULTA:  " + sql);
            return sqlDataSet;
        }

        // LLENAR TABLA POR ID
        public DataSet MostrarViaje(string IDViaje)
        {
            sql = "SET LANGUAGE SPANISH SELECT * FROM VW_VIAJES WHERE [# VIAJE] = " + IDViaje;
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        // LLENAR TABLA
        public DataSet MostrarViajes()
        {
            sql = "SET LANGUAGE SPANISH SELECT * FROM VW_VIAJES";
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        // LLENAR COMBOBOX
        public string LlenarIDViaje()
        {
            sql = "SELECT MAX(ID_VIAJES) + 1 AS ID_VIAJE FROM DET_VIAJES";
            sqlDataSet = ConsultarSQL(sql);
            return sql;
        }

        public DataSet LlenarID()
        {
            sql = "SELECT MAX(ID_VIAJES) + 1 AS ID_VIAJE FROM DET_VIAJES";
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        public DataSet LlenarLugares()
        {
            sql = "SELECT * FROM TBL_LUGARES";
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        public DataSet LlenarMotorista()
        {
            sql = "SELECT ID_MOTORISTA, (NOMBRE_MOTORISTA + ' ' + APELLIDO_MOTORISTA) AS MOTORISTA FROM TBL_MOTORISTAS";
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }

        public DataSet LlenarAutobus()
        {
            sql = "SELECT ID_AUTOBUS, (MARCA + ', ' + MODELO + ', P: ' + NUM_PLACA) AS AUTOBUS FROM TBL_AUTOBUSES";
            sqlDataSet = ConsultarSQL(sql);
            return sqlDataSet;
        }
        // FIN LLENAR COMBOBOX

    }
}
