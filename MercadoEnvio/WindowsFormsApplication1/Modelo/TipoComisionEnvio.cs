using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoEnvioFRBA.Modelo
{
    public class TipoComisionEnvio
    {
        private string _cod_tipo_comision;
        private string _descripcion;

        // gets and sets
        public string cod_tipo_comision
        {
            get { return _cod_tipo_comision; }
            set { _cod_tipo_comision = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public TipoComisionEnvio(string p1, string p2)
        {
            // TODO: Complete member initialization
            this._cod_tipo_comision = p1;
            this._descripcion = p2;
        }
        internal static List<TipoComisionEnvio> getTipos()
        {
            List<TipoComisionEnvio> tipos = DAOTipoComisionEnvio.getTipos();            
            return tipos;
        }
    }
}
