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
        public string pass { get; set; }
        public Int32 user_nro_intentos { set; get; }

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
            this.roles = Rol.rolesDe(this.userId);
           

        }

        public Usuario(string user, string pass) {

            DAOUsuario.getUsuario(user, pass, this);
            this.roles = Rol.rolesDe(this.userId);
        }

        public Usuario()
        {
            
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

        public List<Publicacion> misPuplicaciones()
        {
            return Publicacion.publicacionesDe(this.userId);
        }

        public bool ContraseñaCorrecta()
        {
            return DAOUsuario.contraseñaCorrecta(this);
        }

        public bool contraseñaCorrecta()
        {
            return DAOUsuario.contraseñaCorrecta(this.username, this.pass);
        }

        public bool estaHabilitado() {
            return DAOUsuario.estaHabilitado(this);
        }

        public  void reiniciarFallidos()
        {
            DAOUsuario.reiniciarFallidos(this);
         
        }

        public void actualizarFallidos() {
            DAOUsuario.actualizarFallidos(this);
        }

        public  bool intentosFallidosCompletos()
        {
           return  DAOUsuario.cantidadDefallidos(this) >= 3;
        }

        public void cambiarContraseña(string passNuevo)
        {
            DAOUsuario.cambiarContraseña(passNuevo, this);
        }

        internal List <Compra> tusCompras()
        {
            return DAOCompra.lasComprasDeCliente(this);
        }
    }
}
