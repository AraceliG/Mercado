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
using System.Web;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.ComprarOfertar
    
{
    public partial class Form1 : FormBaseUTN
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridPublicacion.AutoGenerateColumns = false;
            dataGridPublicacion.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCodPublic = new DataGridViewTextBoxColumn();
            colCodPublic.DataPropertyName = "cod_publicacion";
            colCodPublic.HeaderText = "Codigo de Publicacion";
            colCodPublic.Width = 120;
            DataGridViewTextBoxColumn colStock = new DataGridViewTextBoxColumn();
            colStock.DataPropertyName = "stock";
            colStock.HeaderText = "Stock";
            colStock.Width = 120;
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

            dataGridPublicacion.Columns.Add(colCodPublic);
            dataGridPublicacion.Columns.Add(colStock);
            dataGridPublicacion.Columns.Add(colPrecio);
            dataGridPublicacion.Columns.Add(colVendedor);
            dataGridPublicacion.Columns.Add(colFechaInicio);
            dataGridPublicacion.Columns.Add(colFechaFin);
        }

        private void comboBox_rubro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            List<Publicacion> publicaciones = DAOPublicacion.devolverPublicaciones();
            dataGridPublicacion.DataSource = publicaciones;
        }


       
    }
}
