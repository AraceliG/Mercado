using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider_usuario.Clear();
        }

        private void textBox_nro_TextChanged(object sender, EventArgs e)
        {
            errorProvider_nro.Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nroDoc_TextChanged(object sender, EventArgs e)
        {
            errorProvider_nroDoc.Clear();
        }

        private void comboBox_tipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider_tipo_documento.Clear();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider_nombre.Clear();
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider_ape.Clear();
        }

        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        {
            errorProvider_fecha.Clear();
        }

        private void textBox_cod_postal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_psw_TextChanged(object sender, EventArgs e)
        {
            errorProvider_psw.Clear();
        }

        private void textBox_calle_TextChanged(object sender, EventArgs e)
        {
            errorProvider_calle.Clear();
        }

        private void textBox_mail_TextChanged(object sender, EventArgs e)
        {
            errorProvider_mail.Clear();
        }

        private void text_telefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider_tel.Clear();
        }

        private void textBox_localidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider_localidad.Clear();
        }
    }
}
