using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class DatosEmpres : DatosVendedor
    {
        private decimal p;

        public DatosEmpres()
        {
            InitializeComponent();
        }

        public DatosEmpres(decimal p)
        {
            
            this.p = p;

            InitializeComponent();
        }

        private void DatosEmpres_Load(object sender, EventArgs e)
        {

        }
    }
}
