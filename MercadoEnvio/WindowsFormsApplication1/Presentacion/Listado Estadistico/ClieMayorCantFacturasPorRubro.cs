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

namespace MercadoEnvioFRBA.Presentacion.Listado_Estadistico
{
    public partial class ClieMayorCantFacturasPorRubro : Form
    {
        private string anio;
        private string trimestre;
        private List<Rubro> rubros;

        public ClieMayorCantFacturasPorRubro()
        {
            InitializeComponent();
        }

        public ClieMayorCantFacturasPorRubro(string anioForm, string trimestreForm)
        {

            this.anio = anioForm;
            this.trimestre = trimestreForm;
            InitializeComponent();
        }

        private void ClieMayorCantFacturasPorRubro_Load(object sender, EventArgs e)
        {
            rubros = DAORubro.devolverTodos();
            cmbRubro.DataSource = rubros;
            cmbRubro.DisplayMember = "descripcion_larga";
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


            dgvListado.DataSource = daoListadoEstadistico.cliesMayorCantProdComprados(fechaIni, fechaFin, cmbRubro.Text);
        }
    }
}

