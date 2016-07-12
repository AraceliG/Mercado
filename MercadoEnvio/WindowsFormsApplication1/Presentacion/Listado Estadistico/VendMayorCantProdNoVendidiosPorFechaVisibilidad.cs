using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;

namespace MercadoEnvioFRBA.Presentacion.Listado_Estadistico
{
    public partial class VendMayorCantProdNoVendidiosPorFechaVisibilidad : Form
    {
        public string anio;
        public string trimestre;
        private List<Visibilidad> visibilidades;

        public VendMayorCantProdNoVendidiosPorFechaVisibilidad()
        {
            InitializeComponent();
        }

        public VendMayorCantProdNoVendidiosPorFechaVisibilidad(string anioForm, string trimestreForm)
        {
            this.anio = anioForm;
            this.trimestre = trimestreForm;

            InitializeComponent();
            cmbAnio.Items.Add(anio);
            cmbAnio.SelectedItem = anio;
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrimestre.Items.Add(trimestre);
            cmbTrimestre.SelectedItem = trimestre;
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string fechaIni, fechaFin;
            DAOListadoEstadistico daoListadoEstadistico = new DAOListadoEstadistico();

            int trimestre = Convert.ToInt32(cmbTrimestre.SelectedValue);

            if (trimestre == 1)
            {
                fechaIni = cmbAnio.Text + "/01/01 00:00:00";
                fechaFin = cmbAnio.Text + "/03/31 23:59:59";
            }

            else
            {
                if (trimestre == 2)
                {
                    fechaIni = cmbAnio.Text + "/04/01 00:00:00";
                    fechaFin = cmbAnio.Text + "/06/30 23:59:59";
                }
                else
                {
                    if (trimestre == 3)
                    {
                        fechaIni = cmbAnio.Text + "/07/01 00:00:00";
                        fechaFin = cmbAnio.Text + "/09/30 23:59:59";
                    }
                    else
                    {
                        fechaIni = cmbAnio.Text + "/10/01 00:00:00";
                        fechaFin = cmbAnio.Text + "/12/31 23:59:59";
                    }
                }
            }


            dgvListado.DataSource = daoListadoEstadistico.vendMayorCantProdNoVendidos(fechaIni, fechaFin, cmbVisibilidad.Text);
        }

        private void VendMayorCantProdNoVendidiosPorFechaVisibilidad_Load(object sender, EventArgs e)
        {
            visibilidades = DAOVisibilidad.getVisibilidades();
            cmbVisibilidad.DataSource = visibilidades;
            cmbVisibilidad.DisplayMember = "descripcion";
        }
    }
}
