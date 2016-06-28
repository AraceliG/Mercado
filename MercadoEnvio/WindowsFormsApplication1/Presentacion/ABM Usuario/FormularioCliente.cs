using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using System.Configuration;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Datos;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class FormularioCliente : FormUsuario
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTipoDocumentos()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //agrego
                    comboBox_tipoDoc.Items.Add(reader.GetString(0));
                }

                comboBox_tipoDoc.SelectedIndex = 0;
            }

            //libero
            reader.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_tipoDoc.Items.Count <= 0)
            {
                cargarTipoDocumentos();
            }
        }

        private void button_fecha_Click(object sender, EventArgs e)
        {
            Calendario frmCal = new Calendario();
            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() < time)
                {
                    textBox_fecha.Text = frmCal.getFecha();
                }
                else
                {
                    MessageBox.Show("No es una fecha valida.", "Fecha De Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            frmCal.Dispose();  
        }
    }
}
