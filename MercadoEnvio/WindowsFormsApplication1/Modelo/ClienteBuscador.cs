using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    class ClienteBuscador
    {
        public string _nombre;
        public string _apellido;
        public string _email;
        public Int32 _dni;


        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Int32 dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}

