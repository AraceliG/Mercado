using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion
{
    public partial class FormAltaModifPublicacion : FormBaseUTN
    {
        private Publicacion unaPublicacion;

        public FormAltaModifPublicacion()
        {
            InitializeComponent();
            List<Estado> estados = Estado.getEstados();
            this.estado.DataSource = estados;
            this.estado.ValueMember = "cod_estadoPubli";
            this.estado.DisplayMember = "descripcion";

            List<Visibilidad> visibilidades = Visibilidad.buscarVisibilidades( "1=1");
            this.visibilidad.DataSource = visibilidades;
            this.visibilidad.ValueMember = "cod_visibilidad";
            this.visibilidad.DisplayMember = "descripcion";
            
        }

        public FormAltaModifPublicacion(Publicacion unaPublicacion) : this () 
        {
            // TODO: Complete member initialization
            this.unaPublicacion = unaPublicacion;
            this.estado.DataSource = unaPublicacion.miEstado.nuevosEstadosPermitidos();

        }

        private void label_visibilidad_Click(object sender, EventArgs e)
        {

        }

        private void visibilidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void solo_numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal unDecimal;
            if (!Decimal.TryParse(tb.Text + e.KeyChar, out unDecimal) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El dato: '" + tb.Text + e.KeyChar + " 'no es un numero valido", "Error!", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
