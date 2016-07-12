using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.Facturas
{
    public partial class Itemfactura : FormBaseUTN
    {
        private Modelo.Factura fact;

        public Itemfactura()
        {
            InitializeComponent();
        }

        public Itemfactura(Modelo.Factura factura)
        {

            this.fact = factura;
            InitializeComponent();
            List<ItemFactura> items = DAOItemsFactura.getItemsDefactura(fact);
            dataGridView1.DataSource = items;
        }

        private void Itemfactura_factura__Load(object sender, EventArgs e)
        {

        }
    }
}

