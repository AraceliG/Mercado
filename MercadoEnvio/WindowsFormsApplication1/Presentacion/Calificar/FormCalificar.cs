using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.Calificar
{
    public partial class FormCalificar : FormBaseUTN
    {
        private Compra compra;

        public FormCalificar()
        {
            InitializeComponent();
        }

        public FormCalificar(Modelo.Compra compra)
        {
          
            this.compra = compra;
            InitializeComponent();
        }

        private void FormCalificar_Load(object sender, EventArgs e)
        {

        }
    }
}
