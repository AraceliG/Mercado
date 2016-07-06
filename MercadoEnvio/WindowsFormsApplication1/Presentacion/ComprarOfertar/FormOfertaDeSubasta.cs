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
    public partial class FormOfertaDeSubasta : FormBaseUTN
    {
        private Modelo.Publicacion publi;
        private Modelo.Usuario usuario;

        public FormOfertaDeSubasta()
        {
            InitializeComponent();
        }

        public FormOfertaDeSubasta(Publicacion publi, Usuario usuario)
        {
            
            this.publi = publi;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormOfertaDeSubasta_Load(object sender, EventArgs e)
        {

        }
    }
}
