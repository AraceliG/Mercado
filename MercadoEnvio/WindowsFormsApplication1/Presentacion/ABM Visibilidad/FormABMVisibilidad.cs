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

namespace MercadoEnvioFRBA.Presentacion
{
    public partial class FormABMVisibilidad : FormBaseUTN
    {
        public FormABMVisibilidad()
        {
            InitializeComponent();
            List <TipoComisionEnvio> tipos = new List<TipoComisionEnvio>();
            tipos.Add(new TipoComisionEnvio(null, "Ambos"));
            tipos.AddRange(TipoComisionEnvio.getTipos());
            this.tipo_comision_envio.DataSource = tipos;
            this.tipo_comision_envio.ValueMember = "cod_tipo_comision";
            this.tipo_comision_envio.DisplayMember = "descripcion";
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            this.dataGridViewVisibiliadesFiltradas.DataSource =
                Visibilidad.buscarVisibilidades(this.armarFiltro());
        }

        private string armarFiltro()
        {
            string filtro = "1 = 1";
            foreach (Control ctrl in this.grpBoxFiltrosBusqueda.Controls)
            {
                if (ctrl is TextBox && !ctrl.Text.Equals(""))
                {
                    filtro = filtro + " and " + ctrl.Name + " like '%" + ctrl.Text + "%'";
                }
            }

            if(this.permiteEnviosSi.Checked)
                filtro = filtro + " and permite_envios = 1";

            if (this.permiteEnviosNo.Checked)
                filtro = filtro + " and permite_envios = 0";
            
            TipoComisionEnvio tipoComEnv = (TipoComisionEnvio) this.tipo_comision_envio.SelectedItem;
            if( !(tipoComEnv.cod_tipo_comision == null) )
                filtro = filtro + " and cod_tipo_comision_envio = '" + tipoComEnv.cod_tipo_comision + "'";
            return filtro;
        }

        private void grpBoxFiltrosBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.grpBoxFiltrosBusqueda.Controls)
            {
                if (ctrl is TextBox )
                {
                    ctrl.Text = "";
                }
            }

            this.permiteEnviosAmbos.Checked = true;
            this.tipo_comision_envio.SelectedIndex = 0;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado())
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar la visibilidad seleccionada?", "Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult.Equals(DialogResult.OK))
                {
                    Visibilidad unVisibilidad = (Visibilidad)this.dataGridViewVisibiliadesFiltradas.CurrentRow.DataBoundItem;
                    unVisibilidad.darDeBaja();
                    this.button_listar.PerformClick();
                }
            }
            else {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }

        private bool ItemSelccionado()
        {
            return this.dataGridViewVisibiliadesFiltradas.SelectedRows.Count != 0; 
        }

        private void FormABMVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado())
            {
                Visibilidad unVisibilidad = (Visibilidad)this.dataGridViewVisibiliadesFiltradas.CurrentRow.DataBoundItem;
                FormAltaModifVisibilidad altaModifVisi = new FormAltaModifVisibilidad(unVisibilidad);
                altaModifVisi.ShowDialog();
                this.button_listar.PerformClick();

            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }

    }
}
