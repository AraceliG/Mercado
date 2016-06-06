using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.ConexionBaseDatos;
using System.Data.SqlClient;
using System.Configuration;

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

        private bool existeCliente()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.CLIENTE WHERE ";
            cmd.CommandText += "DNI= " + textBox_nroDoc.Text + " AND ";
            cmd.CommandText += "CLI_TIPO_DOCUMENTO = '" + comboBox_tipoDoc.GetItemText(comboBox_tipoDoc.SelectedItem) + "'";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Ya existe un cliente con el mismo número de documento.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //libero
                cmd.Dispose();
                //existe
                return true;
            }
            else
            {
                //libero
                cmd.Dispose();
                //no existe
                return false;
            }
        }


        private void button_guardar_Click(object sender, EventArgs e)
        {
            bool vacio = false;

            if (textBox_usuario.Text == "")
            {
                errorProvider_usuario.SetError(textBox_usuario, "Por favor ingrese el nombre de usuario.");
                vacio = true;
            }

            if (textBox_psw.Text == "")
            {
                errorProvider_psw.SetError(textBox_psw, "Por favor ingrese la contraseña.");
                vacio = true;
            }

            if (textBox_nroDoc.Text == "")
            {
                errorProvider_nroDoc.SetError(textBox_nroDoc, "Por favor ingrese el numero de documento.");
                vacio = true;
            }

            if (textBox_nombre.Text == "")
            {
                errorProvider_nombre.SetError(textBox_nombre, "Por favor ingrese el nombre.");
                vacio = true;
            }

            if (textBox_apellido.Text == "")
            {
                errorProvider_ape.SetError(textBox_apellido, "Por favor ingrese el apellido.");
                vacio = true;
            }

            if (textBox_mail.Text == "")
            {
                errorProvider_mail.SetError(textBox_mail, "Por favor ingrese el mail.");
                vacio = true;
            }

            if (textBox_localidad.Text == "")
            {
                errorProvider_localidad.SetError(textBox_localidad, "Por favor ingrese la localidad.");
                vacio = true;
            }

            if (textBox_calle.Text == "")
            {
                errorProvider_calle.SetError(textBox_calle, "Por favor ingrese la calle.");
                vacio = true;
            }

            if (textBox_nro.Text == "")
            {
                errorProvider_nro.SetError(textBox_nro, "Por favor ingrese la numeracion de la calle.");
                vacio = true;
            }

            if (textBox_fecha.Text == "")
            {
                errorProvider_fecha.SetError(textBox_fecha, "Por favor ingrese la fecha de nacimiento.");
                vacio = true;
            }

            if (text_telefono.Text == "")
            {
                errorProvider_tel.SetError(text_telefono, "Por favor ingrese un teléfono.");
                vacio = true;
            }

            if (vacio) return;


        }

        private void button_fecha_Click(object sender, EventArgs e)
        {
            //nueva instancia
            Calendario frmCal = new Calendario();

            //muestro
            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() < time)
                {
                    //recupero fecha
                    textBox_fecha.Text = frmCal.getFecha();
                    errorProvider_fecha.Clear();
                }
                else
                {
                    // no pudistes haber nacido mañana
                    MessageBox.Show("No es una fecha valida.", "Fecha De Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            //libero
            frmCal.Dispose();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nueva instancia
            Calendario frmCal = new Calendario();

            //muestro
            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() == time)
                {
                    //recupero fecha
                    textBox1.Text = frmCal.getFecha();
                    errorProvider_fecha.Clear();
                }
                else
                {
                    // la creación es ese día, no antes no después
                    MessageBox.Show("No es una fecha válida.", "Fecha De Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            //libero
            frmCal.Dispose();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

