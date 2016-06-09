using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.ConexionBaseDeDatos;
using MercadoEnvioFRBA.ConexionBaseDeDatos.DAO;
using MercadoEnvioFRBA.ConexionBaseDeDatos.BO;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class BuscadorCliente : Form
    {
         

        private void Buscador_Load(object sender, EventArgs e)
        {
            //buscar();
        }
        
        public BuscadorCliente()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            dao = new DAOCliente();
        }

        private DAOCliente dao;
        private List<Cliente> listaClientes { get; set; }
          

        private void button_buscar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        public void actualizarGrilla()

        {  if (textBox_nombre.Text != "" && textBox_nroDoc.Text != "" && textBox_email.Text != "" && textBox_apellido.Text != "") {
            
                
        }
    }
}

