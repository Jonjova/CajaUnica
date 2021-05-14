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
                    command.CommandText = "select * from Usuarios where nombreUsuario=@nombreUsuario and contrasena= @contrasena";
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoginUsuarioCache.usuarioID = reader.GetInt32(0);
                            LoginUsuarioCache.nombre = reader.GetString(3);
                            LoginUsuarioCache.apellido = reader.GetString(4);
                            LoginUsuarioCache.cargo = reader.GetString(5);
                            LoginUsuarioCache.email = reader.GetString(6);
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
        public void AnyMethod() {
            if (LoginUsuarioCache.cargo == Cargos.Administrador)
            {

            }
            if (LoginUsuarioCache.cargo ==Cargos.Recepcionista || LoginUsuarioCache.cargo == Cargos.Contador)
            {
                
            }
        }
    }
}
