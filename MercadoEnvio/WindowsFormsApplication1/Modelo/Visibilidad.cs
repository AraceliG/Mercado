using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Modelo
{
    public class Visibilidad
    {

        public decimal cod_visibilidad { get; set; }
        public string descripcion { get; set; }
        public decimal comision_publicar { get; set; }        
        public decimal comision_vender { get; set; }
        public bool permite_envios { get; set; }
        public string cod_tipo_comision_envio { get; set; }
        public decimal valor_comision_envio { get; set; }
        public bool baja { get; set; }


        internal static List<Visibilidad> buscarVisibilidades(string filtro)
        {   
            List<Visibilidad> visibilidades = DAOVisibilidad.getVisibilidadesQueCumplenCon(filtro);
            return visibilidades.FindAll(v => !v.baja);
        }


        internal void darDeBaja()
        {
            DAOVisibilidad.darDeBaja(this);
        }

        internal void guardar()
        {
            DAOVisibilidad.guardar(this);
        }
    }
}
