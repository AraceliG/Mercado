using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    class Usuario
    {
        public static bool userNameValido(string userName)
        {
            return DAOUsuario.userNameValido(userName);
        }

        public static bool comprobarLogin(string userName, string pass)
        {
            return DAOUsuario.comprobarLogin(userName, pass);
        }
    }
}
