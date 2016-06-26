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

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class FormElegirRol : Form
    {
        string username;

        public FormElegirRol(string usuario)
        {
            InitializeComponent();
            username = usuario;
        }

        private void FormElegirRol_Load(object sender, EventArgs e)
        {
            roles.DataSource = UsuarioBD.ObtenerRoles(username);
            roles.DisplayMember = "nombre";
            roles.ValueMember = "cod_rol";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
