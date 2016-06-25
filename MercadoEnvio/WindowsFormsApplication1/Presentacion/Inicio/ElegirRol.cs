using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Presentacion.Inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class ElegirRol : Form
    {

        private Usuario user;

        public ElegirRol()
        {
            InitializeComponent();
        }

        public ElegirRol(Usuario user)
        {
            
            this.user = user;
            InitializeComponent();
            List<Rol> list = user.roles;
            this.comboBoxElegirRol.DataSource = list;
            this.comboBoxElegirRol.ValueMember = "cod_rol";
            this.comboBoxElegirRol.DisplayMember = "nombre";
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonElegirRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            user.rolActual = (Rol)comboBoxElegirRol.SelectedItem;
            user.rolActual.cargarFuncionalidades();

            FormMenuPrincipal elegirRol = new FormMenuPrincipal(this.user);
            elegirRol.ShowDialog();

            switch (comboBoxElegirRol.SelectedIndex ) {

                case 0:
                   // FormularioCliente accionesCliente = new FormularioCliente();
                    //accionesCliente.ShowDialog();
                    break;
                case 1:
                    //FormularioAdministrador accionesAdministrador = new FormularioAdministrador();
                    //accionesAdministrador.ShowDialog();
                    break;

        }
           
        }
    }
}
