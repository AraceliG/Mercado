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

namespace MercadoEnvioFRBA.Presentacion.Calificar
{
    public partial class FormCalificar : FormBaseUTN
    {
        private Compra compra;
        private Usuario user;

        public FormCalificar()
        {
            InitializeComponent();
        }

        public FormCalificar(Compra compra,Usuario UsuarioEnsesion)
        {
          
            this.compra = compra;
            this.user = UsuarioEnsesion;
            InitializeComponent();
        }

        private void FormCalificar_Load(object sender, EventArgs e)
        {
            dataGridCalif.AutoGenerateColumns = false;
            dataGridCalif.MultiSelect = false;
            cargarGrilla();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            List<Calificacion> calificaciones = DAOCalificacion.getCalificaciones();
            dataGridCalif.DataSource = calificaciones;
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCalificacion = new DataGridViewTextBoxColumn();
            colCalificacion.DataPropertyName = "cant_estrellas";
            colCalificacion.HeaderText = "Calificacion";
            colCalificacion.Width = 120;
            DataGridViewTextBoxColumn colDescripCalif = new DataGridViewTextBoxColumn();
            colDescripCalif.DataPropertyName = "descripcion";
            colDescripCalif.HeaderText = "Descripción";
            colDescripCalif.Width = 120;

            dataGridCalif.Columns.Add(colCalificacion);
            dataGridCalif.Columns.Add(colDescripCalif);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridCalif.RowCount != 0)
            {
                Calificacion calif = (Calificacion)dataGridCalif.CurrentRow.DataBoundItem;
                compra.agregaCalificacion(calif,user,txt_comentario.Text);
                MessageBox.Show("Su califiación ha sido registrada", "Calificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe elegir una calificaión", "Calificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
