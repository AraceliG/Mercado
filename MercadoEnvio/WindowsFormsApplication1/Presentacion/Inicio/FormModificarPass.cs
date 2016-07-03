using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class FormModificarPass : FormBaseUTN
    {
        private Modelo.Usuario user;

        public FormModificarPass()
        {
            InitializeComponent();
        }

        public FormModificarPass(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            txt_user.Text = user.username;
            txt_user.ReadOnly = true;
        }

        private void FormModificarPass_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            bool vacio = false;

            if (txt_pass.Text.Length == 0)
            {
                error_pass_viejo.SetError(txt_pass, "Por favor ingrese su contraseña actual");
                vacio = true;
            }
            else { error_pass_viejo.Clear(); }

            if (txt_nuevoPass.Text.Length == 0)
            {
                error_pass_nuevo1.SetError(txt_nuevoPass, "Por favor ingrese su nueva contraseña");
                vacio = true;
            }
            else { error_pass_nuevo1.Clear(); }

            if (txt_nuevoPass2.Text.Length == 0)
            {
                error_pass_nuevo2.SetError(txt_nuevoPass2, "Por favor ingrese nuevamente su nueva contraseña");
                vacio = true;
            }
            else { error_pass_nuevo2.Clear(); }
            if (vacio) return;
            
            Usuario us = new Usuario();
            us.username = txt_user.Text;
            us.pass = txt_pass.Text;
            if (us.contraseñaCorrecta())
            {
              if( this.coincidenNuevasContraseñas()){

                  us.cambiarContraseña(txt_nuevoPass.Text);
                  MessageBox.Show("Su contraseña ha sido modificada exitosamente!", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  this.Close();

               }
                else{
                 MessageBox.Show("Sus nuevas contraseñas no coinciden", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Contraseña invalida para el usuario " + txt_user.Text, "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

        private bool coincidenNuevasContraseñas()
        {
            return txt_nuevoPass.Text.Equals(txt_nuevoPass2.Text);
        }
    }
}
