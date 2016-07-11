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
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridOfertas.RowCount != 0)
            {
                Oferta o = (Oferta)dataGridOfertas.CurrentRow.DataBoundItem;
            Publicacion pub = new Publicacion();
            pub.cod_publicacion = o.cod_publicacion;
            decimal userVendedorId = DAOPublicacion.getUsuarioVendedor(pub);
            if (DAOEmpresa.tenesEmpresa(userVendedorId))
            {
                DatosEmpres datos = new DatosEmpres(userVendedorId);
                datos.ShowDialog();
                this.Show();
            }
            if (DAOCliente.tenesCliente(userVendedorId))
            {
                DatosCliente datos = new DatosCliente(userVendedorId);
                datos.ShowDialog();
                this.Show();
            }
        }
            else { MessageBox.Show("Debe elegir una fila de su tabla resultado de su ofertas", "Ofertas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
