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
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    public partial class DatosEmpres : DatosVendedor
    {
        private decimal user;

        public DatosEmpres()
        {
            InitializeComponent();
        }

        public DatosEmpres(decimal userId)
        {
            
            this.user = userId;
            InitializeComponent();
            Empresa emp = DAOEmpresa.getEmpresaPorId(user);
            label_razon.Text = emp.razon_social;
            label_cuit.Text = emp.cuit;
            label_nomUser.Text = emp.username;
            label_mail.Text = emp.mail;
            label_tel.Text = emp.telefono;
            label_calle.Text = emp.calle;
            label_nro.Text = Convert.ToString(emp.num_calle);
            label_piso.Text = Convert.ToString(emp.piso);
            label_postal.Text = emp.cod_postal;
            label_reputacion.Text = Convert.ToString(emp.reputacion);
            label_depto.Text = emp.depto;
        }

        private void DatosEmpres_Load(object sender, EventArgs e)
        {

        }
    }
}
