using MercadoEnvioFRBA.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    public class Concepto
    {
       public  Decimal cod_concepto { set; get; }
       public String descripcion { set; get; }

       internal static decimal cod_por_publicar()
       {
           return DAOConcepto.conceptoPorPublicar();
       }
    }
}
