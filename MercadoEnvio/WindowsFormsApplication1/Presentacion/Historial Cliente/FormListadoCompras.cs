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
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Presentacion.Historial_Cliente
{
    public partial class FormListadoCompras : FormBaseUTN
    {
        private Usuario usuario;

        public FormListadoCompras()
        {
            InitializeComponent();
        }

        public FormListadoCompras(Usuario usuario)
        {
            
            this.usuario = usuario;

            InitializeComponent();

           dataGridCompras.AutoGenerateColumns = false;
           dataGridCompras.MultiSelect = false;
             cargarGrilla();
            actualizarGrilla();

        }

        private void actualizarGrilla()
        {
             List<Compra> compras = usuario.tusCompras();
             dataGridCompras.DataSource = compras;
            
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
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "cantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Width = 100;
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.Width = 150;
            DataGridViewTextBoxColumn colEstrellas = new DataGridViewTextBoxColumn();
            colEstrellas.DataPropertyName = "cant_estrellas";
            colEstrellas.HeaderText = "Calificacion";
            colEstrellas.Width = 150;
            DataGridViewTextBoxColumn coltexto = new DataGridViewTextBoxColumn();
            coltexto.DataPropertyName = "txt_libre_calif";
            coltexto.HeaderText = "Comentarios";
            coltexto.Width = 150;

            dataGridCompras.Columns.Add(colCodPublic);
            dataGridCompras.Columns.Add(colCantidad);
            dataGridCompras.Columns.Add(colFecha);
            dataGridCompras.Columns.Add(colEstrellas);
            dataGridCompras.Columns.Add(coltexto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (dataGridCompras.RowCount != 0)
            {
                Compra c = (Compra)dataGridCompras.CurrentRow.DataBoundItem;
                Publicacion pub = new Publicacion();
                pub.cod_publicacion = c.cod_publicacion;
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
            else { MessageBox.Show("Debe elegir una fila de la tabla de sus compras", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
