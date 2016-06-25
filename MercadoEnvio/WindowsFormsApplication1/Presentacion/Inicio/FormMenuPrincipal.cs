using MercadoEnvioFRBA.Modelo;
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
    }
}
