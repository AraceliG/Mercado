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


       internal Decimal tuVendedor()
       {
           return DAOPublicacion.VendedorDePublicacion(this.cod_publicacion);
       }

       internal void CambiaReputacionDe(decimal userIdVendedor)
       {
           DAOUsuario.cambiarReputacionDe(userIdVendedor, this.nuevaReputacion(userIdVendedor));
       }

       private Decimal nuevaReputacion(decimal userIdVendedor)
       {
           return getCantEstrellas(userIdVendedor) / totalVentas(userIdVendedor);
       }

       Decimal totalEstrellas = 0;
       private decimal p1;
       private decimal p2;
       private DateTime dateTime;
       private int p3;

       public Compra(decimal p1, decimal p2, DateTime dateTime, int p3)
       {
           // TODO: Complete member initialization
           this.p1 = p1;
           this.p2 = p2;
           this.dateTime = dateTime;
           this.p3 = p3;
       }

        internal Decimal getCantEstrellas(Decimal userIdVendedor){

            foreach (Compra compra in DAOCompra.getVentasDeUsuario(userIdVendedor)) {

                totalEstrellas = compra.cant_estrellas + totalEstrellas;
            }

            return totalEstrellas;
        
        }

        internal Decimal totalVentas(Decimal userIdVendedor) { 
        // las compras de un user son las ventas de otro user
            return DAOCompra.getVentasDeUsuario(userIdVendedor).Count;
        }

        internal void insertarCompra()
        {
            throw new NotImplementedException();
        }
    }
}
