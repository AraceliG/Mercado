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
using MercadoEnvioFRBA.Presentacion.ABM_Rol;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.ABM_Rol
{
    public partial class ABMrol : FormBaseUTN
    {
        private Usuario usuario;

        public ABMrol()
        {
            InitializeComponent();
        }

        public ABMrol(Modelo.Usuario usuario)
        {
            
            this.usuario = usuario;
            InitializeComponent();

        }

        private void ABMrol_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificarRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarRol buscarRol = new BuscarRol();
            buscarRol.ShowDialog();
            this.Show();
        }

        private void btn_CrearRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            NuevoOModificarRol rolNew = new NuevoOModificarRol();
            rolNew.ShowDialog();
            this.Show();
        }
    }
}
