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

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "" && textBoxUusario.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                if (textBoxPassword.Text == "1212" && textBoxUusario.Text == "admin") {

                    ElegirRol elegirRol = new ElegirRol();
                    elegirRol.ShowDialog();
                }

            }
        }

        private void textBoxUusario_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        
        }
        }
    }
