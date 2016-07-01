using MercadoEnvioFRBA.Modelo;
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
using System.Data.SqlClient;
using MercadoEnvioFRBA.Datos;
using System.Security.Cryptography;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void bienvenidaLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private bool existeUsuario()
        {
            /*  antes ....
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE ";
            cmd.CommandText += "USERNAME = '" + textBoxUsuario.Text + "' ";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            if ((Int32)cmd.ExecuteScalar() < 1)            
            {
                MessageBox.Show("El usuario " + textBoxUsuario.Text + " no existe.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            cmd.Dispose();
            return true;
             * /

            /* despues ...*/
            if ( ! Usuario.userNameValido(textBoxUsuario.Text))
            {
                MessageBox.Show("El usuario " + textBoxUsuario.Text + " no existe.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

       /*ENCRIPTACIÓN NO FUNCIONA
        
        private String encriptarSHA256(String str)
        {
            SHA256Managed hashManaged = new SHA256Managed();

            byte[] hash = hashManaged.ComputeHash(Encoding.Unicode.GetBytes(str));

            return BitConverter.ToString(hash);
        }
        */

        private bool contraseñaCorrecta()
        {
            Usuario us = new Usuario();
            us.username = textBoxUsuario.Text;
            us.pass = textBoxPassword.Text;
            if (us.contraseñaCorrecta()) {
                return true;
            }
           else{
                MessageBox.Show("Contraseña invalida para el usuario " + textBoxUsuario.Text, "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
        }

        private bool usuarioHabilitado()
        {
            Usuario us = new Usuario();
            us.username = textBoxUsuario.Text;
            us.pass = textBoxPassword.Text;
            if (us.intentosFallidosCompletos())
            {

                MessageBox.Show("El usuario se ha inhabilitado, contactese con el administrador.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else { return true; }
        }

           
           /* SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE ";
            cmd.CommandText += "USERNAME= '" + textBoxUsuario.Text + "' ";
            cmd.CommandText += "AND  USER_NRO_INTENTOS < 3";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            if ((Int32)cmd.ExecuteScalar() < 1)
            {
                MessageBox.Show("El usuario se ha inhabilitado, contactese con el administrador.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            cmd.Dispose();
            return true;
        }*/

        void borrarIntentosFallidos()
        {
            Usuario us = new Usuario();
            us.username = textBoxUsuario.Text;
            us.reiniciarFallidos();
            /*
             * SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO ";
            cmd.CommandText += "SET USER_NRO_INTENTOS = 0 ";
            cmd.CommandText += "WHERE USERNAME = '" + textBoxUsuario.Text + "'";
            cmd.Connection = cmd.Connection = AccesoBaseDeDatos.GetConnection();

            if (cmd.ExecuteNonQuery() < 1)
            {
                MessageBox.Show("Error al actualizar el campo USER_NRO_INTENTOS de tabla USUARIO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.Dispose();
             * */
        }


       /* private int intentosFallidos()
        {
            Usuario us = new Usuario();
            us.username = textBoxUsuario.Text;
            if (us.estaHabilitado())
            {
                us.actualizarFallidos();

            }
            else {
                MessageBox.Show("Error al leer el campo USER_NRO_INTENTOS en la tabla USUARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        */ 
           /* SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT USER_NRO_INTENTOS FROM NOTHING_IS_IMPOSSIBLE.USUARIO ";
            cmd.CommandText += "WHERE USERNAME = '" + textBoxUsuario.Text + "'";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int cant = reader.GetInt32(0);
                reader.Close();
                cmd.Dispose();
                return cant;
            }
            else
            {
                reader.Close();
                cmd.Dispose();
                MessageBox.Show("Error al leer el campo USER_NRO_INTENTOS en la tabla USUARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }*/

        void incrementarIntentosFallidos()
        {
            Usuario us = new Usuario();
            us.username = textBoxUsuario.Text;
            if (us.intentosFallidosCompletos())
            {
                MessageBox.Show("Error al leer el campo USER_NRO_INTENTOS en la tabla USUARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                us.actualizarFallidos();
            }

         /*   
            Int32 cantIntentosFallidos = 0;
            if ((cantIntentosFallidos = intentosFallidos()) != -1)
            {
                if (cantIntentosFallidos < 3)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE NOTHING_IS_IMPOSSIBLE.USUARIO ";
                    cmd.CommandText += "SET USER_NRO_INTENTOS = " + (cantIntentosFallidos + 1) + " ";
                    cmd.CommandText += "WHERE USERNAME = '" + textBoxUsuario.Text + "'";
                    cmd.Connection = cmd.Connection = AccesoBaseDeDatos.GetConnection();
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Error al actualizar el campo USER_NRO_INTENTOS de tabla USUARIO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
          */ 

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool vacio = false;

            if (textBoxUsuario.Text.Length == 0)
            {
                errorUser.SetError(textBoxUsuario, "Por favor ingrese usuario");
                vacio = true;
            }
            else { errorUser.Clear(); }

            if (textBoxPassword.Text.Length == 0)
            {
                errorPass.SetError(textBoxPassword, "Por favor ingrese contraseña");
                vacio = true;
            }
            else { errorPass.Clear(); }

            if (vacio) return;

            if (existeUsuario())
            {
               if ( usuarioHabilitado())
                {
                    if (contraseñaCorrecta())
                    {
                        borrarIntentosFallidos();

                        Usuario user = new Usuario(textBoxUsuario.Text);
                        this.Hide();
                        elegirRol(user);
                        this.Show();
                        
                        /* antes ...
                        elegirRol(textBoxUsuario.Text);
                        borrarIntentosFallidos();
                        this.Close();*/
                    }
                    else { incrementarIntentosFallidos(); 
                    }
                }
               // else
              //  { }
            }//

            /*
            if (textBoxPassword.Text == "" && textBoxUusario.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                if (this.userNameValido(textBoxUusario.Text) && this.comprobarLogin(textBoxPassword.Text, textBoxUusario.Text))
                {
                    Usuario user = new Usuario(textBoxUusario.Text);
                    this.Hide();
                    ElegirRol elegirRol = new ElegirRol(user);
                    elegirRol.ShowDialog();
                    this.Show();
                } 
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error!", MessageBoxButtons.OK);
                    return;
               

            }*/
        //
 }
        private void elegirRol(Usuario user)
        {
            FormElegirRol elegRol = new FormElegirRol(user);
            elegRol.ShowDialog();
        }

        private bool userNameValido(string unUserName)
        {
            return Usuario.userNameValido(unUserName);
        }

        private bool comprobarLogin(string password, string username)
        {
            return Usuario.comprobarLogin(username, password);
        }

        private void textBoxUusario_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
