using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MercadoEnvioFRBA.ConexionBaseDatos;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class CrearEmpresa : Form
    {
        public CrearEmpresa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void textBox_razon_social_TextChanged(object sender, EventArgs e)
        {
            errorProvider_razon_social.Clear();
        }

        private void textBox_mail_TextChanged(object sender, EventArgs e)
        {
            errorProvider_mail.Clear();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider_usuario.Clear();
        }

        private void textBox_psw_TextChanged(object sender, EventArgs e)
        {
            errorProvider_psw.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider_fecha.Clear();
        }

        private void textBox_cuit_TextChanged(object sender, EventArgs e)
        {
            errorProvider_cuit.Clear();
        }

        private bool existeEmpresaConEseCuit()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.EMPRESA ";
            cmd.CommandText += "WHERE CUIT= '" + textBox_cuit.Text + "'";

            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Ya existe una empresa con el mismo número de cuit", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool existeClienteConEsaRazonSocial() {

            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.EMPRESA ";
            cmd.CommandText += "WHERE RAZON_SOCIAL= '" + textBox_razon_social.Text + "'";

            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Ya existe una empresa con la misma razón social", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        private bool existeEseNombreDeLoginDeUsuario()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE ";
            cmd.CommandText += "USERNAME = '" + textBox_usuario.Text + "'";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
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


        private bool existeMailIngresado()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE ";
            cmd.CommandText += "UPPER(EMAIL) LIKE UPPER('%" + textBox_mail.Text + "%')";

            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Ya existe una empresa registrada con ese e-mail.", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private String encriptarSHA256(String str)
        {
            //encriptación de otro tp
            SHA256Managed hashManaged = new SHA256Managed();

            byte[] hash = hashManaged.ComputeHash(Encoding.Unicode.GetBytes(str));

            return BitConverter.ToString(hash);
        }


        private void insertarUsuario()
        {
            //inserto usuario
            SqlCommand cmd = new SqlCommand();

            //fecha del archivo de configuracion
            DateTime fecha = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

            //AGREGAR FECHA DE CREACION EN LA TABLA DE LA BASE DE DATOS EN LA TABLA USUARIO: 
            //VA PARA CLIENTE Y PARA EMPRESA

            cmd.CommandText = "INSERT INTO NOTHING_IS_IMPOSSIBLE.USUARIO (USERNAME,PASS,EMAIL,CALLE,NUM_CALLE) ";
            cmd.CommandText += "VALUES('" + textBox_usuario.Text + "',";
            cmd.CommandText += "'" + encriptarSHA256(textBox_psw.Text) + "',";
            //HABILITADO
            //INTENTOS FALLIDOS
            //USER NUMERO DE INTENTOS FALLIDOS
            cmd.CommandText += "'" + textBox_mail.Text + "',";
            //TELEFONO
            cmd.CommandText += "'" + textBox_calle.Text + "',";
            cmd.CommandText += "" + textBox_nro.Text + ")";
            //PISO
            //DEPTO
            //CODIGO POSTAL

            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            if (cmd.ExecuteNonQuery() < 1)
            {
                //fallo
                MessageBox.Show("Error al insertar en la tabla USUARIO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //libero
                cmd.Dispose();
                return;
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

            if (textBox_cuit.Text == "")
            {
                errorProvider_cuit.SetError(textBox_cuit, "Por favor ingrese el número de CUIT.");
                vacio = true;
            }

            if (textBox_razon_social.Text == "")
            {
                errorProvider_razon_social.SetError(textBox_razon_social, "Por favor ingrese la razón social.");
                vacio = true;
            }

            if (textBox_mail.Text == "")
            {
                errorProvider_mail.SetError(textBox_mail, "Por favor ingrese el mail.");
                vacio = true;
            }
            if (textBox1.Text == "")
            {
                errorProvider_fecha.SetError(textBox1, "Por favor ingrese la fecha de creación.");
                vacio = true;
            }
            if (vacio) return;
            if (!existeEmpresaConEseCuit() && !existeClienteConEsaRazonSocial())
            {
                if (!existeEseNombreDeLoginDeUsuario())
                {
                    if (!existeMailIngresado())
                    {
                       // insertarEmpresa();
                        insertarUsuario();
                        MessageBox.Show("SE HA CREADO EL USUARIO EXITOSAMENTE!!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Ese mail ya se encuentra registrado.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ya es utilizado por otro usuario ", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("El usuario ya existe", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void insertarEmpresa()
        {

            //inicializar command para enviarle instruccion sql
            SqlCommand cmd = new SqlCommand();

            // jjeje, arreglar eso en base de datos :acepta el nombre_contaco y no nombre_contaCTO.

            //AGREGAR FECHA DE CREACION EN LA TABLA DE LA BASE DE DATOS EN LA TABLA USUARIO: 
            //VA PARA CLIENTE Y PARA EMPRESA

            cmd.CommandText = "INSERT INTO NOTHING_IS_IMPOSSIBLE.EMPRESA (CUIT,RAZON_SOCIAL,NOMBRE_CONTACO,CIUDAD) ";
            cmd.CommandText += "VALUES('" + textBox_cuit.Text + "',";
            cmd.CommandText += "'" + textBox_razon_social.Text + "',";
            cmd.CommandText += "'" + textBox_nombre_de_contacto.Text + "',";
            cmd.CommandText += "'" + textBox_ciudad.Text + "')";

            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            if (cmd.ExecuteNonQuery() < 1)
            {
                //fallo
                MessageBox.Show("Error al insertar en la tabla USUARIO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //libero
                cmd.Dispose();
                return;
            }
            
        }
    }
}
