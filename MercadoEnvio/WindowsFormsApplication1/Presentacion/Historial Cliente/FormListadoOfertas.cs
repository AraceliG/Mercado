using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Presentacion.Historial_Cliente
{
    public partial class FormListadoOfertas : FormBaseUTN
    {
        private Modelo.Usuario usuario;

        public FormListadoOfertas()
        {
            InitializeComponent();
        }

        public FormListadoOfertas(Modelo.Usuario usuario)
        {
            
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormListadoOfertas_Load(object sender, EventArgs e)
        {

        }
    }
}
