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

namespace MercadoEnvioFRBA.Presentacion.Historial_Cliente
{
    public partial class FormListadoOfertas : FormBaseUTN
    {
        private Modelo.Usuario usuario;

        public FormListadoOfertas()
        {
            InitializeComponent();
        }

        public FormListadoOfertas(Usuario usuario)
        {
            
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormListadoOfertas_Load(object sender, EventArgs e)
        {
            dataGridOfertas.AutoGenerateColumns = false;
            dataGridOfertas.MultiSelect = false;
            cargarGrilla();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            List<Oferta> ofertas = usuario.tusOfertas();
            dataGridOfertas.DataSource = ofertas;
            
            
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCodPublic = new DataGridViewTextBoxColumn();
            colCodPublic.DataPropertyName = "cod_publicacion";
            colCodPublic.HeaderText = "Codigo de Publicacion";
            colCodPublic.Width = 120;
            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "monto";
            colMonto.HeaderText = "Monto";
            colMonto.Width = 150;
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.Width = 150;
            DataGridViewTextBoxColumn colEstadoOferta = new DataGridViewTextBoxColumn();
            colEstadoOferta.DataPropertyName = "ganadora";
            colEstadoOferta.HeaderText = " Estado ";
            colEstadoOferta.Width = 150;

            dataGridOfertas.Columns.Add(colCodPublic);
            dataGridOfertas.Columns.Add(colMonto);
            dataGridOfertas.Columns.Add(colFecha);
            dataGridOfertas.Columns.Add(colEstadoOferta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
