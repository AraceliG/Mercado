using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using MercadoEnvioFRBA.Presentacion;


namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class Calendario : FormBaseUTN
    {
        private DateTime fecha;

        public Calendario()
        {
            InitializeComponent();
        }

        private void button_sel_Click(object sender, EventArgs e)
        {
            fecha = monthCalendar.SelectionRange.Start;

            //como seleccione una fecha quiero que al etornar el form devuleva yes
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {   //fijo la fecha del archivo de configuracion
            DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            monthCalendar.TodayDate = time;
            monthCalendar.SelectionStart = time;
        }

        public String getFecha()
        {
            return fecha.ToString("yyyy-MM-dd HH:MM:ss");
        }

        public DateTime getFechaDateTime()
        {
            return fecha;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
