using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.Modelo
{
    public class Compra
    {
       public Decimal cod_publicacion {set;get;}
       public Decimal userId {set;get;}
       public DateTime fecha {set;get;}
       public Int32 cantidad {set;get;}
       public Int32 cant_estrellas{set;get;}
       public String txt_libre_calif {set;get;}


       internal void agregaCalificacion(Calificacion calif,Usuario user, String comentario)
       {
           DAOCompra.agregateCalificacion(this,calif,user,comentario);
       }
    }
}
