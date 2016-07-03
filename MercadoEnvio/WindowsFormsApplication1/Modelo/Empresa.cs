using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
   public class Empresa
    {
        public Int32 userId { get; set; }
        public String razon_social { set; get; }
        public String mail { get; set; }
        public String telefono { get; set; }
        public String cuit{ get; set; }
        public String rubroPrincipal { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public Int32 cantFallidos { get; set; }
        public String calle { get; set; }
        public Int32 num_calle { get; set; }
        public Int32 piso { get; set; }
        public String depto { get; set; }
        public String cod_postal { get; set; }
        public Boolean habilitado { get; set; }
        public Boolean baja { set; get; }
        public Int32 reputacion { set; get; }
        public Int32 user_nro_intentos { set; get; }
        public String nombre_contacto{set;get;}
        public String ciudad { set; get; }



    }
}
