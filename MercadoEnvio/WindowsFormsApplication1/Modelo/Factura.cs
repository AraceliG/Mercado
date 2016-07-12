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
        public List<ItemFactura> items { set; get; }
       

        public Factura() 
        {
            this.items = new List<ItemFactura>();
        }

        internal void insertarFactura()
        {
            DAOFactura.generarFactura(this); 
        }

        internal void insertarItem(ItemFactura unItem)
        {
            unItem.nro_factura = this.nro_factura;
            DAOFactura.generarItem(unItem);
            this.items.Add(unItem);
        }
    }

    public class ItemFactura
    {
        public decimal nro_factura { set; get; }
        public decimal nro_item { set; get; }
        public decimal cod_concepto { set; get; }
        public decimal monto { set; get; }
        public decimal cantidad { set; get; } 
        public string descripcion { get; set; }
    }
}
