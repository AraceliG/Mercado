using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ComprarOfertar
{
    public partial class FormCompra : FormBaseUTN
    {
        private Publicacion publi;
        private Usuario usuario;

        public FormCompra()
        {
            InitializeComponent();
        }

        public FormCompra(Publicacion publi, Usuario usuario)
        {
            
            this.publi = publi;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
