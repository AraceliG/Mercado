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
    public partial class CrearRol : FormBaseUTN
    {

        public CrearRol()
        {
            InitializeComponent();
        }

        private void CrearRol_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        public void actualizarGrilla() {
            List<Funcionalidad> listaDeRoles = new List<Funcionalidad>();
            listaDeRoles = DAOFuncionalidad.buscarFuncionalidades();
            dataGridFuncionalidad.DataSource = listaDeRoles;
        
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


        }
    }
}
