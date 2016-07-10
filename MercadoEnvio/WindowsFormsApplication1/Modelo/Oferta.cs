using MercadoEnvioFRBA.Datos.DAO;
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

       internal static Oferta buscarGanadora(decimal cod_publicacion)
       {
           return DAOOferta.buscarGanadora(cod_publicacion);
       }

       internal void ponerGanadora()
       {
           DAOOferta.ponerGanadora(this);
       }
    }
}
