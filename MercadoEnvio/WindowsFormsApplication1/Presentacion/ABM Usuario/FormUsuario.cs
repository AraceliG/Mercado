using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.ABM_Usuario;
using System.Configuration;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class FormUsuario : FormBaseUTN
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label_cod_visibilidad_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario frmCal = new Calendario();

            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() == time)
                {
                    textBox1.Text = frmCal.getFecha();
                }
                else
                {
                    MessageBox.Show("No es una fecha válida.", "Fecha De Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            frmCal.Dispose();  
        }



    }
}
