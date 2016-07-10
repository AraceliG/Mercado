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
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Presentacion.Facturas
{
    public partial class FacturasVendedor : FormBaseUTN
    {
        public FacturasVendedor()
        {
            InitializeComponent();
        }

        private void misFacturas_Load(object sender, EventArgs e)
        {
            dataGridFacturas.AutoGenerateColumns = false;
            dataGridFacturas.MultiSelect = false;
            cargarGrilla();
            actualizarGrilla();

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCodFactura = new DataGridViewTextBoxColumn();
            colCodFactura.DataPropertyName = "nro_factura";
            colCodFactura.HeaderText = "Código de Factura";
            colCodFactura.Width = 120;
            DataGridViewTextBoxColumn colCodPublic = new DataGridViewTextBoxColumn();
            colCodPublic.DataPropertyName = "cod_publicacion";
            colCodPublic.HeaderText = "Codigo de Publicacion";
            colCodPublic.Width = 120;
            DataGridViewTextBoxColumn colTotalFactura = new DataGridViewTextBoxColumn();
            colTotalFactura.DataPropertyName = "total";
            colTotalFactura.HeaderText = "Total Factura";
            colTotalFactura.Width = 120;
            DataGridViewTextBoxColumn colVendedor = new DataGridViewTextBoxColumn();
            colVendedor.DataPropertyName = "userId";
            colVendedor.HeaderText = "identificador de usuario";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFormaPago = new DataGridViewTextBoxColumn();
            colFormaPago.DataPropertyName = "forma_pago_desc";
            colFormaPago.HeaderText = "Forma de Pago";
            colFormaPago.Width = 120;

            dataGridFacturas.Columns.Add(colCodPublic);
            dataGridFacturas.Columns.Add(colCodFactura);
            dataGridFacturas.Columns.Add(colTotalFactura);
            dataGridFacturas.Columns.Add(colVendedor);
            dataGridFacturas.Columns.Add(colFecha);
            dataGridFacturas.Columns.Add(colFormaPago);
        }

        private void actualizarGrilla()
        {
            List<Factura> facturas = DAOFactura.getFacturas();
            dataGridFacturas.DataSource = facturas;
        }


        private void groupBoxDeFechas_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Length != 0 && txt_cuil.Text.Length != 0)
            {
                MessageBox.Show("debe ingresar dni ó cuit, no ambos", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                List<Factura> facturas = DAOFactura.cumpleConFiltros(txt_dni.Text, txt_cuil.Text, txt_numFact.Text, txt_importeDesde.Text, txt_importeHasta.Text, timeDesde.Value, timeHasta.Value, check_formaPago.Checked);
                dataGridFacturas.DataSource = facturas;
                MessageBox.Show("Su busqueda ha finalizado con éxito!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void check_formaPago_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_cuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txt_importeDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_importeDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_importeHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
