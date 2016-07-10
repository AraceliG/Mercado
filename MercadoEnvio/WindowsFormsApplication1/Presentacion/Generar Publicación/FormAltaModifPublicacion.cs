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
        private Publicacion publicacionActual;
        private bool generarFactura = false;

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
            this.publicacionActual = unaPublicacion;

            if (this.publicacionActual.cod_tipo_publicacion.Equals("C"))
            {
                this.tipo_publicacionCompra.Checked = true;
            }
            else
            {
                this.tipo_publicacionSubasta.Checked = true;
            }

            if (this.publicacionActual.acepta_preguntas)
            {
                this.acepta_preguntasSi.Checked = true;
            }
            else
            {
                this.acepta_preguntasNo.Checked = true;
            }

            if (this.publicacionActual.ofrece_envios)
            {
                this.ofrece_enviosSi.Checked = true;
            }
            else
            {
                this.ofrece_enviosNo.Checked = true;
            }

            this.estado.DataSource = this.publicacionActual.miEstado.nuevosEstadosPermitidos();
            this.cod_publicacion.Text = this.publicacionActual.cod_publicacion.ToString();
            this.descripcion.Text = this.publicacionActual.descripcion;
            this.precio.Text = this.publicacionActual.precio.ToString();
            this.stock.Text = this.publicacionActual.stock.ToString();
            this.costo.Text = this.publicacionActual.costo.ToString();
            this.visibilidad.SelectedValue = this.publicacionActual.cod_visibilidad;
            this.fecha_inicio.Value = this.publicacionActual.fecha_inicio;
            this.fecha_vencimiernto.Value = this.publicacionActual.fecha_vencimiernto;

        }

        public FormAltaModifPublicacion(decimal userId) : this ()
        {
            // TODO: Complete member initialization
            this.generarFactura = true;
            this.publicacionActual = new Publicacion();
            this.publicacionActual.userId = userId;
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

        private void FormAltaModifPublicacion_Load(object sender, EventArgs e)
        {

        }

        private void visibilidad_SelectedValueChanged(object sender, EventArgs e)
        {
            Visibilidad unaVisibilidad = (Visibilidad) this.visibilidad.SelectedItem;

            if (unaVisibilidad.permite_envios)
            {
                this.ofrece_enviosNo.Enabled = true;
                this.ofrece_enviosSi.Enabled = true;
            }
            else
            {
                this.ofrece_enviosNo.Enabled = true;
                this.ofrece_enviosSi.Enabled = false;
                this.ofrece_enviosNo.Checked = true;
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            
            decimal unDecimal;

            if (Decimal.TryParse(this.cod_publicacion.Text, out unDecimal))
                this.publicacionActual.cod_publicacion = unDecimal;

            if (Decimal.TryParse(this.precio.Text, out unDecimal))
                this.publicacionActual.precio = unDecimal;

            if (Decimal.TryParse(this.stock.Text, out unDecimal))
                this.publicacionActual.stock = unDecimal;

            if (Decimal.TryParse(this.costo.Text, out unDecimal))
                this.publicacionActual.costo = unDecimal;

            this.publicacionActual.descripcion = this.descripcion.Text;

            this.publicacionActual.cod_visibilidad = (decimal) this.visibilidad.SelectedValue;

            this.publicacionActual.fecha_inicio = this.fecha_inicio.Value;
            this.publicacionActual.fecha_vencimiernto = this.fecha_vencimiernto.Value;

            this.publicacionActual.miEstado = (Estado) this.estado.SelectedItem;

            if(this.tipo_publicacionCompra.Checked){
                this.publicacionActual.cod_tipo_publicacion = "C";
            }
            else
            {
                this.publicacionActual.cod_tipo_publicacion = "S";
            }

            this.publicacionActual.acepta_preguntas = this.acepta_preguntasSi.Checked;

            this.publicacionActual.ofrece_envios = this.ofrece_enviosSi.Checked;

            if (publicacionActual.guardar() > 0)
            {
                if(this.generarFactura)
                {
                    this.generarFacturaPorPublicar();
                }

                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }
        }

        private void generarFacturaPorPublicar()
        {
            this.generarFactura = false;
            Visibilidad unaVisi = (Visibilidad) this.visibilidad.SelectedItem;
            Factura unFactura = new Factura();
            unFactura.cod_publicacion = this.publicacionActual.cod_publicacion;
            unFactura.userId = this.publicacionActual.userId;
            unFactura.fecha = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            unFactura.total = unaVisi.comision_publicar;
            unFactura.forma_pago_desc = "Efectivo";            
            unFactura.insertarFactura();

            ItemFactura unItem = new ItemFactura();
            unItem.cantidad = 1;
            unItem.monto = unaVisi.comision_publicar;
            unItem.cod_concepto = Concepto.cod_por_publicar();
            unFactura.insertarItem(unItem);       
        }
    }
}
