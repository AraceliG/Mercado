using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    public class Funcionalidad
    {
        private String _nombre;
        private decimal _cod_funcionalidad;

        // gets and sets
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal cod_funcionalidad
        {
            get { return _cod_funcionalidad; }
            set { _cod_funcionalidad = value; }
        }
    }
}
