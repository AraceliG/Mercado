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
using System.Web;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.ComprarOfertar
    
{
    public partial class Form1 : FormBaseUTN
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_rubro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            List<Publicacion> publicaciones = DAOPublicacion.devolverPublicaciones();
            dataGridPublicacion.DataSource = publicaciones;
        }
    }
}
