using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using MercadoEnvioFRBA.ABM_Rol;
using MercadoEnvioFRBA.ComprarOfertar;
using MercadoEnvioFRBA.Historial_Cliente;
using MercadoEnvioFRBA.Presentacion.ABM_Rol;
using MercadoEnvioFRBA.Presentacion.Historial_Cliente;

namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    public partial class FormMenuPrincipal : Form
    {
        private Usuario usuario;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public FormMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.Enabled = false;
                    if(usuario.FuncionalidadValida(boton.Text))
                    {
                        boton.Enabled=true;                        
                    }
                }
            }
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void func4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEnConstruccion unForm = new FormEnConstruccion();
            unForm.Text = "ABM Rubros";
            unForm.ShowDialog();
            this.Show();
        }

        private void func5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMVisibilidad unForm = new FormABMVisibilidad();
            unForm.ShowDialog();
            this.Show();
        }


        private void func6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGenerarPublicacion unForm = new FormGenerarPublicacion(usuario);
            unForm.ShowDialog();
		}

        private void func3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormABMUsuario formUser = new FormABMUsuario();
            formUser.ShowDialog();
            this.Show();
        }

        private void func2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMrol buscarRol = new ABMrol();
            buscarRol.ShowDialog();
            this.Show();
        }

        private void func7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formCompraOferta = new Form1(usuario);
            formCompraOferta.ShowDialog();
            this.Show();

        }

        private void func8_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistorialMenu historial = new HistorialMenu(usuario);
            historial.ShowDialog();
            this.Show();


        }

        private void func9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPendientesCalificar pendientesCalif = new FormPendientesCalificar(usuario);
            pendientesCalif.ShowDialog();
            this.Show();
        }
    }
}
