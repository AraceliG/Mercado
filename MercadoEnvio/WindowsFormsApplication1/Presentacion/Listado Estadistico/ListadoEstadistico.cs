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

namespace MercadoEnvioFRBA.Presentacion.Listado_Estadistico
{
    public partial class ListadoEstadistico : FormBaseUTN
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            cargarTrimestres();
            camgarAnios();
            cmbAnio.SelectedIndex = 0;
            cargarTiposListados();
        }

        private void cargarTrimestres()
        {
            Dictionary<int, string> trimestres = new Dictionary<int, string>();
            trimestres.Add(1, "1er. trimestre");
            trimestres.Add(2, "2do. trimestre");
            trimestres.Add(3, "3er. trimestre");
            trimestres.Add(4, "4do. trimestre");
            cmbTrimestre.DataSource = new BindingSource(trimestres, null);
            cmbTrimestre.DisplayMember = "Value";
            cmbTrimestre.ValueMember = "Key";
        }

        private void camgarAnios()
        {
            for (int i = 2000; i < 2020; i++)
                cmbAnio.Items.Add(i);
        }

        private void cargarTiposListados()
        {
            Dictionary<int, string> listados = new Dictionary<int, string>();
            listados.Add(1, "Vendedores con mayor cantidad de productos no vendidos");
            listados.Add(2, "Clientes con mayor cantidad de productos comprados");
            listados.Add(3, "Vendedores con mayor cantidad de facturas");
            listados.Add(4, "Vendedores con mayor monto facturado");
            cmbListado.DataSource = new BindingSource(listados, null);
            cmbListado.DisplayMember = "Value";
            cmbListado.ValueMember = "Key";
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

            switch (Convert.ToInt32(cmbListado.SelectedValue))
            {
                case 1:
                    this.Hide();
                    VendMayorCantProdNoVendidiosPorFechaVisibilidad vend = new VendMayorCantProdNoVendidiosPorFechaVisibilidad(cmbAnio.Text, cmbTrimestre.Text);
                    vend.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    this.Hide();
                    ClieMayorCantFacturasPorRubro clie = new ClieMayorCantFacturasPorRubro(cmbAnio.Text, cmbTrimestre.Text);
                    clie.ShowDialog();
                    this.Show();
                    ;
                    break;
                case 3:
                    dgvListado.DataSource = daoListadoEstadistico.VendConMayorCantFact(fechaIni, fechaFin);
                    break;
                case 4:
                    dgvListado.DataSource = daoListadoEstadistico.VendConMayorMontoFact(fechaIni, fechaFin);
                    break;
            }


        }


    }
}

