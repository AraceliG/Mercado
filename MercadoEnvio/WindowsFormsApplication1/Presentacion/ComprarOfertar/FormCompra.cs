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
            label_fecha.Text = ConfigurationManager.AppSettings["fecha"];
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            if (txt_cantidadCompra.Text.Length == 0)
            {
                error_cant.SetError(txt_cantidadCompra, "debe ingresar una cantidad");
                vacio = true;
            }
            else { error_cant.Clear(); }
            if (vacio) return;

            int number;
            if (!(Int32.TryParse(txt_cantidadCompra.Text, out number))) {
                MessageBox.Show("Se debe ingresar un número entero", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Int32 cantidadComprada = Convert.ToInt32(txt_cantidadCompra.Text);

            if (publi.tieneStock(cantidadComprada))
            {
                publi.facturar(cantidadComprada,Convert.ToDateTime(label_fecha.Text));
                publi.documentarCompra(usuario,cantidadComprada,label_fecha.Text);
                publi.actualizarStock(cantidadComprada);
                if (publi.finStock()) {
                    publi.finalizar();
                }
                
                 MessageBox.Show(" la compra se ha realizado con éxito", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 this.Close();
            }
            else {   MessageBox.Show("La cantidad ingresada supera al stock disponible, por favor ingrese una cantidad menor", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
        }

        private void txt_cantidadCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cantidadCompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
