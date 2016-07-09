using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Modelo
{
    public class Factura
    {
        public decimal nro_factura { set; get; }
        public decimal cod_publicacion { set; get; }
        public decimal userId { set; get; }
        public DateTime fecha { set; get; }
        public decimal total { set; get; }
        public String forma_pago_desc { set; get; }

        public void generarFactura() {
            DAOFactura.generarFactura(this);
        }

    }
}
