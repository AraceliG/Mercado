using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion
{
    public partial class FormAltaModifVisibilidad : FormBaseUTN
    {


        public FormAltaModifVisibilidad()
        {
            InitializeComponent();
            List<TipoComisionEnvio> tipos = TipoComisionEnvio.getTipos();
            this.tipo_comision_envio.DataSource = tipos;
            this.tipo_comision_envio.ValueMember = "cod_tipo_comision";
            this.tipo_comision_envio.DisplayMember = "descripcion";
        }

        public FormAltaModifVisibilidad(Visibilidad unVisibilidad) : this()
        {
            this.Text = "Modificacion Visibilidad";
            this.cod_visibilidad.Text = unVisibilidad.cod_visibilidad.ToString();
            this.descripcion.Text = unVisibilidad.descripcion;
            this.comision_publicar.Text = unVisibilidad.comision_publicar.ToString();
            this.comision_vender.Text = unVisibilidad.comision_vender.ToString();
            this.valor_comision_envio.Text = unVisibilidad.valor_comision_envio.ToString();

            if (unVisibilidad.permite_envios)
            {
                this.permiteEnviosSi.Checked = true;
            }
            else {
                this.permiteEnviosNo.Checked = true;
            }

            this.tipo_comision_envio.SelectedValue = unVisibilidad.cod_tipo_comision_envio;
        }

        private void FormAltaModifVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void comision_publicar_TextChanged(object sender, EventArgs e)
        {

        }

        private void validarSoloNumeros(object sender, EventArgs e)
        {
            TextBox tb = (TextBox) sender;
            decimal unDecimal;
            if (! Decimal.TryParse( tb.Text, out unDecimal))
            {
                MessageBox.Show("Numero no valido", "Error!", MessageBoxButtons.OK);
                tb.Focus();
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            Visibilidad unaVisibilidad = new Visibilidad();
            decimal unDecimal;

            if(Decimal.TryParse(this.cod_visibilidad.Text, out unDecimal))
                unaVisibilidad.cod_visibilidad = unDecimal;
            
            if (Decimal.TryParse(this.comision_publicar.Text, out unDecimal))
                unaVisibilidad.comision_publicar = unDecimal;

            if (Decimal.TryParse(this.comision_vender.Text, out unDecimal))
                unaVisibilidad.comision_vender = unDecimal;

            if(Decimal.TryParse(this.valor_comision_envio.Text, out unDecimal))
                unaVisibilidad.valor_comision_envio = unDecimal;

            unaVisibilidad.descripcion = this.descripcion.Text;
            
            unaVisibilidad.permite_envios = this.permiteEnviosSi.Checked;

            unaVisibilidad.cod_tipo_comision_envio = this.tipo_comision_envio.SelectedValue.ToString();

            if (unaVisibilidad.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }

        }

    }
}
