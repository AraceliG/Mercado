using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MercadoEnvioFRBA.ConexionBaseDatos;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class BuscadorCliente : Form
    {
         

        private void Buscador_Load(object sender, EventArgs e)
        {
            

        }
        
        public BuscadorCliente()
        {
            InitializeComponent();
            //listaClientes = new List<Cliente>();
            //dao = new DAOCliente();
        }

        //private DAOCliente dao;
        //private List<Cliente> listaClientes { get; set; }
          

        private void button_buscar_Click(object sender, EventArgs e)
        {
           // actualizarGrilla();
        }

        public void actualizarGrilla()

        {
            SqlConnection cn = AccesoBaseDeDatos.GetConnection();

            SqlCommand cmd = new SqlCommand("Select * from Cliente", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView.DataSource = dt;

            cn.Close();
        }
    }
}

