using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.ConexionBaseDatos;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class BuscadorCliente : Form

    {
        BindingSource bindingSource = null;
         




        public BuscadorCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void cargarDatagrid(String consulta)
        {
            //nuevo
            bindingSource = new BindingSource();
            //
            dataGridView.DataSource = bindingSource;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            //consulta para llenar el datagrid
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.CommandText = consulta;
            dataAdapter.SelectCommand.Connection = AccesoBaseDeDatos.GetConnection();

            //nuevo
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //nueva
            DataTable tabla = new DataTable();
            //
            bindingSource.DataSource = tabla;

            //cargamos el datagrid
            dataAdapter.Fill(tabla);

            //libero
            dataAdapter.Dispose();
            //libero
            commandBuilder.Dispose();
            //libero
            tabla.Dispose();
        }

        private void buscar()
        {

            bindingSource = new BindingSource();
            //
            dataGridView.DataSource = bindingSource;
           
            String conslt = "SELECT ";
            conslt += "DNI,";
            conslt += "NOMBRE,";
            conslt += "APELLIDO";
            conslt += "FROM NOTHING_IS_IMPOSSIBLE.CLIENTE";

            String filtro = "";
            if (textBox_nombre.Text != "")
            {
                filtro = "NOMBRE LIKE '%" + textBox_nombre.Text + "%'";
            }

            if (textBox_apellido.Text != "")
            {
                filtro += (filtro != "") ? " AND " : "";
                filtro += "APELLIDO LIKE '%" + textBox_apellido.Text + "%'";
            }

            if (textBox_nroDoc.Text != "")
            {
                filtro += (filtro != "") ? " AND " : "";
                filtro += "DNI = " + textBox_nroDoc.Text + "";
            }


            //le agrego filtros?
            if (filtro != "")
            {
                conslt += " WHERE " + filtro;
            }

           /*
            * //busco solo los clientes que estan sin eliminar?
            if (!buscarEliminados)
            {
                if (filtro != "")
                {
                    //no muestra clientes eliminados
                    conslt += " AND CLI_ELIMINADO = 0";
                }
                else
                {
                    //no muestra clientes eliminados
                    conslt += " WHERE CLI_ELIMINADO = 0";
                }
            }
            */

            //a cargar el datagrid
            cargarDatagrid(conslt);

            //edito nombre de columnas del datagrid
            dataGridView.Columns[0].HeaderText = "Nro de Doc.";
            dataGridView.Columns[2].HeaderText = "Nombre";
            dataGridView.Columns[3].HeaderText = "Apellido";
            //dataGridView.Columns[4].HeaderText = "Mail";
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_email.Text = "";
            textBox_nroDoc.Text = "";
        }
    }
}
