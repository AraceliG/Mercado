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
             //if (textBox_cuit.Text != "" || textBox_razon.Text != "" || textBox_email.Text != "" )
                listaDeEmpresas = DAOEmpresa.buscarPorFiltros(textBox_cuit.Text, textBox_razon.Text, textBox_email.Text);
            //else
                //listaDeEmpresas = DAOEmpresa.devolverUsuariosEmpresas();
            /*dataGridEmpresa.DataSource = DAOEmpresa.devolverUsuariosEmpresas(textBox_razon.Text, textBox_email.Text, textBox_cuit.Text);
            
          
            if (textBox_cuit.Text != null && textBox_email.Text != null  && textBox_razon.Text != null)
            {
                List<Empresa> empresaList = DAOEmpresa.devolverUsuariosEmpresas();
                List<Empresa> tablaEmpresa = new List<Empresa>();
                foreach (Empresa empresa in empresaList)
                {
                    if (empresa.cuit.ToString().ToUpper().StartsWith(textBox_cuit.Text.ToUpper()) &&  empresa.mail.ToString().ToUpper().StartsWith(textBox_email.Text.ToUpper()) && empresa.razon_social.ToString().ToUpper().StartsWith(textBox_razon.Text.ToUpper()))
                    {
                        tablaEmpresa.Add(empresa);
                    }
                }
*/
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



    }
}
