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
using MercadoEnvioFRBA.Presentacion.Historial_Cliente;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Historial_Cliente
{
    public partial class HistorialMenu : FormBaseUTN
    {
        private Usuario usuario;

        public HistorialMenu()
        {
            InitializeComponent();
        }

        public HistorialMenu(Modelo.Usuario usuario)
        {
           
            this.usuario = usuario;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoCompras buscarRol = new FormListadoCompras(usuario);
            buscarRol.ShowDialog();
            this.Show();
        }

        private void func2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoOfertas buscarRol = new FormListadoOfertas(usuario);
            buscarRol.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPendientesCalificar pendientesCalif = new FormPendientesCalificar(usuario);
            pendientesCalif.ShowDialog();
            this.Show();
        }
    }
}
