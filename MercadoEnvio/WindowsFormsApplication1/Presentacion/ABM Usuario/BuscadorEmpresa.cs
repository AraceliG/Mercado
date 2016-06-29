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
            if (textBox_cuit.Text != null && textBox_email.Text != null  && textBox_razon.Text != null)
            {
                List<Empresa> empresaList = DAOEmpresa.devolverUsuarios();
                List<Empresa> tablaEmpresa = new List<Empresa>();
                foreach (Empresa empresa in empresaList)
                {
                    if (empresa.cuit.ToString().ToUpper().StartsWith(textBox_cuit.Text.ToUpper()) &&  empresa.mail.ToString().ToUpper().StartsWith(textBox_email.Text.ToUpper()) && empresa.razon_social.ToString().ToUpper().StartsWith(textBox_razon.Text.ToUpper()))
                    {
                        tablaEmpresa.Add(cliente);
                    }
                }

                dataGridEmpresa.DataSource = tablaEmpresa;
            }
        }
    }
}
