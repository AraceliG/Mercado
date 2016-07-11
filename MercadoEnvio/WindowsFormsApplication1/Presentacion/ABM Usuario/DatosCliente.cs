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

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class DatosCliente : DatosVendedor
    {
        private decimal userId;

        public DatosCliente()
        {
            InitializeComponent();
        }

        public DatosCliente(decimal user)
        {
           
            this.userId = user;
            
            InitializeComponent();

            Cliente clie = DAOCliente.getClientePorId(userId);
            label_nombre.Text = clie.nombre;
            label_ape.Text = clie.apellido;
            label_nomUser.Text = clie.username;
            label_dni.Text = Convert.ToString(clie.dni);
            label_mail.Text = clie.mail;
            label_tel.Text = clie.telefono;
            label_calle.Text = clie.calle;
            label_nro.Text = Convert.ToString(clie.num_calle);
            label_piso.Text = Convert.ToString(clie.piso);
            label_postal.Text = clie.cod_postal;
            label_reputacion.Text = Convert.ToString(clie.reputacion);
            label_depto.Text = clie.depto;
        }

        private void DatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
