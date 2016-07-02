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
using MercadoEnvioFRBA.Datos;
using MercadoEnvioFRBA.Presentacion;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class BuscadorCliente : FormBaseUTN
    {


        private void Buscador_Load(object sender, EventArgs e)
        {


        }

        public BuscadorCliente()
        {
            InitializeComponent();
        }


        private void button_buscar_Click(object sender, EventArgs e)
        {
            if (textBox_nroDoc.Text != null && textBox_email.Text != null && textBox_nombre.Text != null && textBox_apellido.Text != null)
            {
                List<Cliente> clienteList = DAOCliente.devolverUsuarios();
                List<Cliente> tablaClientes = new List<Cliente>();
                foreach (Cliente cliente in clienteList)
                {
                    if (cliente.dni.ToString().StartsWith(textBox_nroDoc.Text) && cliente.nombre.ToString().ToUpper().StartsWith(textBox_nombre.Text.ToUpper()) && cliente.apellido.ToString().ToUpper().StartsWith(textBox_apellido.Text.ToUpper()) && cliente.mail.ToString().ToUpper().StartsWith(textBox_email.Text.ToUpper()))
                    {
                        tablaClientes.Add(cliente);
                    }               
                }

                dataGridCliente.DataSource = tablaClientes;
            }
           
            }
       

        private void BuscadorCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox_nroDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_apellido.Clear();
            textBox_email.Clear();
            textBox_nroDoc.Clear();
            textBox_nombre.Clear();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataGridCliente.CurrentRow.DataBoundItem;
            FormularioCliente forClient = new FormularioCliente(cliente);
            forClient.ShowDialog();
            this.Show();

        }
    }
}

