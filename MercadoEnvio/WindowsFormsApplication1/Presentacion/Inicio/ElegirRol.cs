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
    public partial class ElegirRol : Form
    {
        public ElegirRol()
        {
            InitializeComponent();
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonElegirRol_Click(object sender, EventArgs e)
        {
            switch (comboBoxElegirRol.SelectedIndex ) {
                case 0:
                   // FormularioCliente accionesCliente = new FormularioCliente();
                    //accionesCliente.ShowDialog();
                    break;
                case 1:
                    //FormularioAdministrador accionesAdministrador = new FormularioAdministrador();
                    //accionesAdministrador.ShowDialog();
                    break;

        }
           
        }
    }
}
