using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
     public class Publicacion
    {

        public Estado miEstado { get; set; }

        public decimal cod_publicacion { get; set; }

        public string cod_tipo_publicacion { get; set; }

        public DateTime fecha_vencimiernto { get; set; }

        public decimal stock { get; set; }

        public decimal precio { get; set; }

        public decimal costo { get; set; }

        public string descripcion { get; set; }

        public bool acepta_preguntas { get; set; }

        public bool ofrece_envios { get; set; }

        public decimal cod_visibilidad { get; set; }

        public DateTime fecha_inicio { get; set; }

        internal static object buscarPublicaciones(string filtro)
        {
            return DAOPublicacion.getPublicacionesConfiltro(filtro);
        }

        internal static List<Publicacion> publicacionesDe(decimal userId)
        {
            return DAOPublicacion.getPublicacionesDe(userId);
        }

        internal static Publicacion getPublicacion(decimal cod_publicacion)
        {
            return DAOPublicacion.getPublicacion(cod_publicacion);
        }


    }
}
