using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class DatosCliente : DatosVendedor
    {
        private decimal p;

        public DatosCliente()
        {
            InitializeComponent();
        }

        public DatosCliente(decimal p)
        {
           
            this.p = p;

            InitializeComponent();
        }

        private void DatosCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
