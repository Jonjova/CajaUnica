using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.cache;

namespace AccesoDatos
{
    public class UsuarioDAO : ConexionSQL
    {
        public bool Login(string usuario, string contra)
        {
            using (var conex = obtenerConex())
            {
                conex.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conex;
                    command.CommandText = "SELECT * FROM VW_USUARIOS WHERE NOMBRE_USUARIO=@nombreUsuario and CONTRASENA=@contrasena";
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoginUsuarioCache.ID_USUARIO = reader.GetInt32(0);
                            LoginUsuarioCache.NOMBRE_USUARIO = reader.GetString(1);
                            LoginUsuarioCache.NOMBRE_CONTROL = reader.GetString(3);
                            LoginUsuarioCache.NOMBRE_ROL = reader.GetString(4);
                            LoginUsuarioCache.FECHA_CREA = reader.GetDateTime(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void AnyMethod()
        {
            if (LoginUsuarioCache.ID_ROL == Cargos.Administrador)
            {
                //hola
            }
            if (LoginUsuarioCache.ID_ROL == Cargos.Digitador)
            {

            }
        }
    }
}
