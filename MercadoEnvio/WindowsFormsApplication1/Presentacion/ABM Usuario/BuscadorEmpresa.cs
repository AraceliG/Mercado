using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class BuscadorEmpresa : FormBaseUTN
    {
        public BuscadorEmpresa()
        {
            InitializeComponent();
        }

        private void BuscadorEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btn_busquedaEmp_Click(object sender, EventArgs e)
        {
             List<Empresa> listaDeEmpresas= new List<Empresa>();
                listaDeEmpresas = DAOEmpresa.buscarPorFiltros(textBox_cuit.Text, textBox_razon.Text, textBox_email.Text);
                dataGridEmpresa.DataSource = listaDeEmpresas;
            }

            


        private void textBox_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox_cuit.Clear();
            textBox_email.Clear();
            textBox_razon.Clear();
        }

        private void textBox_cuit_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
