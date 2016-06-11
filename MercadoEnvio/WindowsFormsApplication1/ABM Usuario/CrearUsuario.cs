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
using System.Security.Cryptography;

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
            errorProvider_tipo_doc.Clear();
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



        private bool existeClienteConEseNumeroDeDocumento()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.CLIENTE ";
           cmd.CommandText += "WHERE DNI= '" + textBox_nroDoc.Text +"'";
           
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Ya existe un cliente con el mismo número de documento y tipo de documento.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool existeClienteConEseTipoDeDocumento() {
                        //consulta
            SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "SELECT*FROM NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO";
           // cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //FUNCIONARÁ???
            //finalmente probado y no funciona

            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T,NOTHING_IS_IMPOSSIBLE.CLIENTE C WHERE T.COD_TIPO_DOC=C.COD_TIPO_DOC";
            cmd.CommandText += " AND T.DESCRIPCION= '" + comboBox_tipoDoc.Text + "'";
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
                MessageBox.Show("Ya existe un cliente registrado con ese e-mail.", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (comboBox_tipoDoc.Items.Count <= 0)
            {
                errorProvider_tipo_doc.SetError(comboBox_tipoDoc, "Por favor ingrese Tipo De Documento.");
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

            if (!existeClienteConEseNumeroDeDocumento())
            {
                if (!existeEseNombreDeLoginDeUsuario())
                {
                    if (!existeMailIngresado())
                    {   
                        insertarCliente();
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
            else {
                MessageBox.Show("El usuario ya existe", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




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

            //pendiente insertar rol cliente

            
        }

        private void insertarCliente()
        {
            SqlCommand cmd = new SqlCommand();

            //inserto cliente
            cmd.CommandText = "INSERT INTO NOTHING_IS_IMPOSSIBLE.CLIENTE (DNI,APELLIDO,NOMBRE) ";
            cmd.CommandText += "VALUES (" + textBox_nroDoc.Text + ",";
           //cmd.CommandText += "'" + comboBox_tipoDoc.GetItemText(comboBox_tipoDoc.SelectedItem) + "',";
            cmd.CommandText += "'" + textBox_apellido.Text + "',";
            cmd.CommandText += "'" + textBox_nombre.Text + "'" + ")";
           // cmd.CommandText += "CONVERT(DATETIME,'" + textBox_fecha.Text + "',121),";
            //cmd.CommandText += "CONVERT(DATETIME,'" + textBox1.Text + "',121),";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();


          


            if (cmd.ExecuteNonQuery() < 1)
            {
                //fallo
                MessageBox.Show("Error al insertar en la tabla CLIENTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //libero
                cmd.Dispose();
                return;
            }


            //exito
            MessageBox.Show("Se ha creado el cliente de forma satisfactoria.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //libero
            cmd.Dispose();
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
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox_tipoDoc.Items.Count <= 0)
            {
                cargarTipoDocumentos();
            }
        }


       
            }


    }

