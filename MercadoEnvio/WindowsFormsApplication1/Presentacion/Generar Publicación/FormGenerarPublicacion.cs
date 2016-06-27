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
    public partial class FormGenerarPublicacion : FormBaseUTN
    {
        private Usuario usuarioActual;

        public FormGenerarPublicacion()
        {
            InitializeComponent();
        }

        public FormGenerarPublicacion(Modelo.Usuario usuario) : this ()
        {
            this.usuarioActual = usuario;
            
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            this.dataGridViewPublicacionesFiltradas.DataSource = Publicacion.buscarPublicaciones(this.armarFiltro());
        }

        private string armarFiltro()
        {
            string filtro = "userId = " + this.usuarioActual.userId.ToString();

            foreach (Control ctrl in this.groupBoxDeTexto.Controls)
            {
                if (ctrl is TextBox && !ctrl.Text.Equals(""))
                {
                    filtro = filtro + " and " + ctrl.Name + " like '%" + ctrl.Text + "%'";
                }
            }

            foreach (Control ctrl in this.groupBoxDeMagnitud.Controls)
            {
                if (ctrl is Label )
                {
                    TextBox desde = (TextBox) this.groupBoxDeMagnitud.Controls.Find(ctrl.Name + "_desde", true)[0];
                    TextBox hasta = (TextBox)this.groupBoxDeMagnitud.Controls.Find(ctrl.Name + "_hasta", true)[0];

                    if (!desde.Text.Equals("") )
                        filtro = filtro + " and " + ctrl.Name + " >= " + desde.Text ;

                    if (!hasta.Text.Equals(""))
                        filtro = filtro + " and " + ctrl.Name + " <= " + hasta.Text;
                }
            }

            foreach (Control ctrl in this.groupBoxDeFechas.Controls)
            {
                if (ctrl is Label)
                {
                    DateTimePicker desde = (DateTimePicker)this.groupBoxDeFechas.Controls.Find(ctrl.Name + "_desde", true)[0];
                    DateTimePicker hasta = (DateTimePicker)this.groupBoxDeFechas.Controls.Find(ctrl.Name + "_hasta", true)[0];

                    if (desde.Checked)
                        filtro = filtro + " and " + ctrl.Name + " >= CONVERT(datetime, '" + desde.Value + "')";

                    if (hasta.Checked)
                        filtro = filtro + " and " + ctrl.Name + " <= CONVERT(datetime, '" + hasta.Value + "')";
                }
            }

            /*** los radio button ***/
            if (this.tipo_publicacionCompra.Checked)
                filtro = filtro + " and tipo_publicacion = 'Compra'";

            if (this.tipo_publicacionSubasta.Checked)
                filtro = filtro + " and tipo_publicacion = 'Subasta'";

            if (this.acepta_preguntasSi.Checked)
                filtro = filtro + " and acepta_preguntas = 1";

            if (this.acepta_preguntasNo.Checked)
                filtro = filtro + " and acepta_preguntas = 0";

            if (this.ofrece_enviosSi.Checked)
                filtro = filtro + " and ofrece_envios = 1";

            if (this.ofrece_enviosNo.Checked)
                filtro = filtro + " and ofrece_envios = 0";


            return filtro;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormGenerarPublicacion_Load(object sender, EventArgs e)
        {

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarForm();
        }

        private void limpiarForm()
        {
            foreach (Control ctrl in this.grpBoxFiltrosBusqueda.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            this.tipo_publicacionAmbos.Checked = true;
            this.acepta_preguntasAmbos.Checked = true;
            this.ofrece_enviosAmbos.Checked = true;

            foreach (Control ctrl in this.groupBox_fecha_desde.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker myDtp = (DateTimePicker)ctrl;

                    myDtp.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                    myDtp.Checked = false;
                }
            }
            foreach (Control ctrl in this.groupBox_fecha_hasta.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker myDtp = (DateTimePicker)ctrl;

                    myDtp.Value = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                    myDtp.Checked = false;
                }
            }
        }
    }
}
