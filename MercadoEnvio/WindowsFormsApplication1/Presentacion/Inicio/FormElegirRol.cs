using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Datos;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class FormElegirRol : FormBaseUTN
    {
        private Usuario user;

        public FormElegirRol()
        {
            InitializeComponent();
        }

        public FormElegirRol(Usuario user) : this ()
        {            
            this.user = user;
            List<Rol> list = user.roles;
            this.roles.DataSource = list;
            this.roles.ValueMember = "cod_rol";
            this.roles.DisplayMember = "nombre";
        }

        private void FormElegirRol_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user.rolActual = (Rol)roles.SelectedItem;
            user.rolActual.cargarFuncionalidades();

            FormMenuPrincipal elegirRol = new FormMenuPrincipal(this.user);
            elegirRol.ShowDialog();

            switch (roles.SelectedIndex ) {

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

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            FormModificarPass formUser = new FormModificarPass(user);
            formUser.ShowDialog();
            formUser.Close();
            this.Show();
            this.Close();
        }
    }
}
