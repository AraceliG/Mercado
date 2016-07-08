using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion.Historial_Cliente
{
    public partial class FormListadoCompras : FormBaseUTN
    {
        private Modelo.Usuario usuario;

        public FormListadoCompras()
        {
            InitializeComponent();
        }

        public FormListadoCompras(Modelo.Usuario usuario)
        {
            
            this.usuario = usuario;

            InitializeComponent();
        }

        private void FormListadoCompras_Load(object sender, EventArgs e)
        {
           

        }

      

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCodPublic = new DataGridViewTextBoxColumn();
            colCodPublic.DataPropertyName = "cod_publicacion";
            colCodPublic.HeaderText = "Codigo de Publicacion";
            colCodPublic.Width = 120;
            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "stock";
            colMonto.HeaderText = "Stock";
            colMonto.Width = 120;
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Width = 120;
            DataGridViewTextBoxColumn colVendedor = new DataGridViewTextBoxColumn();
            colVendedor.DataPropertyName = "userId";
            colVendedor.HeaderText = "identificador de usuario";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaInicio.DataPropertyName = "fecha_inicio";
            colFechaInicio.HeaderText = "Fecha de Inicio";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFechaFin = new DataGridViewTextBoxColumn();
            colFechaFin.DataPropertyName = "fecha_vencimiernto";
            colFechaFin.HeaderText = "Fecha de Vencimiento";
            colFechaFin.Width = 120;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
