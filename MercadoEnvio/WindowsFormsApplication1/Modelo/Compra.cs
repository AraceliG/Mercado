using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    class Compra
    {
       public Decimal cod_publicacion {set;get;}
       public Decimal userId {set;get;}
       public DateTime fecha {set;get;}
       public Int32 cantidad {set;get;}
       public Int32 cant_estrellas{set;get;}
       public String txt_libre_calif {set;get;}

    }
}
