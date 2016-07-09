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
using System.Configuration;

namespace MercadoEnvioFRBA.Presentacion.ComprarOfertar
{
    public partial class FormOfertaDeSubasta : FormBaseUTN
    {
        private Publicacion publi;
        private Usuario usuario;

        public FormOfertaDeSubasta()
        {
            InitializeComponent();
        }

        // DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"])

        public FormOfertaDeSubasta(Publicacion publi, Usuario usuario)
        {
            
            this.publi = publi;
            this.usuario = usuario;
            InitializeComponent();
            label_ultimaOferta.Text= publi.precio.ToString();
            label_fecha.Text = ConfigurationManager.AppSettings["fecha"];
        }

        private void FormOfertaDeSubasta_Load(object sender, EventArgs e)
        {

        }

        Int32 oferta;

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            oferta = Convert.ToInt32(txt_oferta.Text);
            if (esMayorOferta(oferta))
            { publi.actualizarPrecio(oferta);
                publi.ofertate(oferta, usuario,label_fecha.Text);
                MessageBox.Show("Su oferta se ha realizado con éxito ", "Oferta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            else {
                MessageBox.Show("Su oferta no supera a la actual, debe ingresar un valor mayor ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool esMayorOferta(int oferta)
        {
            return this.publi.precio < oferta;
        }

        private void txt_oferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
