using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    class Oferta
    {
       public Decimal cod_publicacion {set;get;}
       public Decimal userId {set;get;}
       public DateTime fecha {set;get;}
       public Decimal monto {get;set;}
       public Boolean ganadora { get; set; }

       internal static Oferta buscarGanadora(decimal p)
       {
           throw new NotImplementedException();
       }

       internal void guardar()
       {
           throw new NotImplementedException();
       }
    }
}
