using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Presentacion.ABM_Rol
{
    public partial class BuscarRol : FormBaseUTN
    {
        public BuscarRol()
        {
            InitializeComponent();
        }

        //BUSCADOR

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        public void actualizarGrilla() {

            List<Rol> listaDeRoles = new List<Rol>();
            listaDeRoles = DAORol.buscarRoles();
            dataGridRol.DataSource = listaDeRoles;
        
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            if (dataGridRol.RowCount != 0)
            {
                Rol rol = (Rol)dataGridRol.CurrentRow.DataBoundItem;
                DAORol.altaLogica(rol);
                this.actualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila de su tabla resultado de su búsqueda", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridRol.RowCount != 0)
            {
                Rol rol = (Rol)dataGridRol.CurrentRow.DataBoundItem;
                DAORol.bajaLogica(rol);
                this.actualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila de su tabla resultado de su búsqueda", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_modificarRol_Click(object sender, EventArgs e)
        {

        }
    }
}
