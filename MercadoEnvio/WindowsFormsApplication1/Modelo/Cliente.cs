using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    public class Cliente
    {
        public Int32 userId { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String telefono { get; set; }
        public Int32 dni { get; set; }
        public String descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String calle { get; set; }
        public Int32 num_calle { get; set; }
        public Int32 piso { get; set; }
        public String depto { get; set; }
        public String cod_postal { get; set; }
        public Boolean habilitado { get; set; }
        public Boolean baja { set; get; }
        public Decimal reputacion { set; get; }
        public Int32 user_nro_intentos { set; get; }
        public Int32 cod_tipo_doc { get; set; }
    }

   
}


