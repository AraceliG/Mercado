using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    public class Usuario
    {

        private string _username;
        private decimal _userId;
        private List<Rol> _roles;
        private Rol _rolActual;

        // gets and sets
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public decimal userId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public List<Rol> roles
        {
            get { return _roles; }
            set { _roles = value; }
        }
        public Rol rolActual
        {
            get { return _rolActual; }
            set { _rolActual = value; }
        }

        // Demas metodos
        public Usuario(string userName)
        {
            DAOUsuario.getUsuario(userName, this);

        }

        public static bool userNameValido(string userName)
        {
            return DAOUsuario.userNameValido(userName);
        }

        public static bool comprobarLogin(string userName, string pass)
        {
            return DAOUsuario.comprobarLogin(userName, pass);
        }

        internal bool FuncionalidadValida(string nombreFuncionalidad)
        {
            return this.rolActual.funcionalidadValida(nombreFuncionalidad);
        }
    }
}
