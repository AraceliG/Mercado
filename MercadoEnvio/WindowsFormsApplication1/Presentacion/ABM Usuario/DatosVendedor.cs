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
    public partial class DatosVendedor : FormBaseUTN
    {
        private decimal userId;

        public DatosVendedor()
        {
            InitializeComponent();
        }

        public DatosVendedor(decimal user)
        {
            // TODO: Complete member initialization
            this.userId = user;
            InitializeComponent();

        }

        private void DatosVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
