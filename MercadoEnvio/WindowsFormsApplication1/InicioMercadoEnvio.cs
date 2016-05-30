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

namespace MercadoEnvioFRBA
{
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            FormularioLogin login = new FormularioLogin();
            login.ShowDialog();
        }
    }
}
