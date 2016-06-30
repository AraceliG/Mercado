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
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class FormABMUsuario : FormBaseUTN
    {

        public FormABMUsuario()
        {
            InitializeComponent();
        }

        private void FormABMUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioEmpresa formUser = new FormularioEmpresa();
            formUser.ShowDialog();
            this.Show();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioCliente formUser = new FormularioCliente();
            formUser.ShowDialog();
            formUser.Close();
            //this.Show();
            this.Close();
        }

        private void btn_BusquedaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscadorCliente buscarCliente = new BuscadorCliente();
            buscarCliente.ShowDialog();
            this.Show();
        }

        private void btn_busquedaEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscadorEmpresa buscarCliente = new BuscadorEmpresa();
            buscarCliente.ShowDialog();
            this.Show();
        }
    }
}
