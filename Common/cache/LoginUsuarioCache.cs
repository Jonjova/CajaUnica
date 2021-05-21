using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cache
{
    public static class LoginUsuarioCache
    {
        public static int ID_USUARIO { get; set; }
        public static string CONTRASENA { get; set; }
        public static string NOMBRE_USUARIO { get; set; }
        public static string APELLIDO_USUARIO { get; set; }
        public static int ID_ROL { get; set; }
        public static DateTime FECHA_CREA { get; set; }
    }
}
