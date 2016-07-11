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
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;

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

        public void textBox_usuario_TextChanged(object sender, EventArgs e)
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

        public bool existeUsername()
        {
            Cliente clientBusq = new Cliente();
            clientBusq.username = textBox_usuario.Text;
            return DAOCliente.existeUsuario(clientBusq);
        }


        public void textBox_psw_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox_mail_TextChanged(object sender, EventArgs e)
        {

        }

        public void text_telefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void textBox_calle_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox_nro_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox_piso_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox_depto_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox_cod_postal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cod_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_nro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void text_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



      
    }
}
