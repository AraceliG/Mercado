using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    public class Rol
    {
        private string _nombre;
        private decimal _cod_rol;
        private List<Funcionalidad> _funcionalidades;
       public  bool baja { set; get; }
        bool habilitado { set; get; }

        // gets and sets
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal cod_rol
        {
            get { return _cod_rol; }
            set { _cod_rol = value; }
        }

        public List<Funcionalidad> funcionalidades
        {
            get { return _funcionalidades; }
            set { _funcionalidades = value; }
        }

        // Metodos  de Clase
        internal static List<Rol> rolesDe(decimal userId)
        {
            return DAORol.getRolesDe(userId);
        }

        // Metodos de instancia
        internal bool funcionalidadValida(string nombreFuncionalidad)
        {
            return this.funcionalidades.Any(func => func.nombre.Equals(nombreFuncionalidad));
        }

        internal void cargarFuncionalidades()
        {
            this.funcionalidades = DAOFuncionalidad.getFuncionalidadesDe(this.cod_rol);
        }
    }
}
