using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Dominio
{
    public class UsuarioModelo
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public bool LoginUser(string usuario, string contra)
        {
            return usuarioDAO.Login(usuario, contra);
        }
    }
}
