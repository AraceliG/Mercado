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

        public Decimal cod_publicacion { get; set; }

        public string cod_tipo_publicacion { get; set; }

        public DateTime fecha_vencimiernto { get; set; }

        public Decimal stock { get; set; }

        public decimal precio { get; set; }

        public decimal costo { get; set; }

        public string descripcion { get; set; }

        public bool acepta_preguntas { get; set; }

        public bool ofrece_envios { get; set; }

        public decimal cod_visibilidad { get; set; }

        public DateTime fecha_inicio { get; set; }

        public Decimal userId { get; set; }

        Decimal montoEnvio;
        Decimal montoVenta;

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



        public bool cumpleConFiltros(string descripcionPubli, string rubro0, string rubro1, string rubro2, string rubro3)
        {
            return DAOPublicacion.cumpleFiltros(this, descripcionPubli, rubro0, rubro1, rubro2, rubro3);
        }

        public bool laHizoUsuario(Usuario usuario)
        {
            return DAOPublicacion.hizoUsuarioPublicacion(this, usuario);
        }

        public bool estaPausada()
        {
            return DAOPublicacion.estaPausada(this);
        }

       public bool esCompra()
        {
            return DAOPublicacion.esCompra(this);
        }


       internal bool tieneStock(int cantidadComprada)
       {
           return stock >= cantidadComprada;
               
               //DAOPublicacion.tieneStockPublicacion(this,cantidadComprada);
       }

       internal void facturar(Int32 stock,DateTime fechaCompra)
       {
           Factura unFactura = new Factura();
           unFactura.cod_publicacion = this.cod_publicacion;
           unFactura.userId = this.userId;
           unFactura.fecha = fechaCompra;
           unFactura.total = this.totalFactura();
           unFactura.forma_pago_desc = "Efectivo";
           unFactura.insertarFactura();


           ItemFactura unItem = new ItemFactura();
           unItem.cantidad = 1;
           unItem.monto = this.montoDeVenta();
           unItem.cod_concepto = DAOConcepto.conceptoPorVenta();
           unFactura.insertarItem(unItem);

           if (this.correspondeEnvio()) 
           {
               ItemFactura otroItem = new ItemFactura();
               otroItem.cantidad = 2;
               otroItem.monto = this.montoDeEnvio();
               otroItem.cod_concepto = DAOConcepto.conceptoPorEnvio();
               unFactura.insertarItem(unItem);

           }
       }

       private bool correspondeEnvio()
       {
           return DAOVisibilidad.comisionPorEnvio(DAOPublicacion.obtenerVisibilidad(this)) != 0;
       }


       internal Decimal montoDeVenta()
       {
           return montoVenta=this.precio * DAOVisibilidad.comosionPorVenta(DAOPublicacion.obtenerVisibilidad(this));
          
       }

       internal Decimal montoDeEnvio()
       {

           return montoEnvio = DAOVisibilidad.comisionPorEnvio(DAOPublicacion.obtenerVisibilidad(this));
          
       }

       internal Decimal totalFactura()
       {
           return montoEnvio + montoEnvio;
       }

       internal void documentarCompra(Usuario usuario,int stock,String fecha)
       {
           DAOCompra.documentarCompra(this, stock,usuario,fecha);
       }

         Decimal stockViejo;
         Decimal nuevoStock;

       internal void actualizarStock(Decimal cantidadComprada)
       {
           
           stockViejo = DAOPublicacion.obtenerStock(this);
           nuevoStock = stockViejo - cantidadComprada;
           DAOPublicacion.actualizarStock(this,nuevoStock );
       }

       internal bool finStock()
       {
          return  DAOPublicacion.esFinStock(this);
       }

       internal void finalizar()
       {
           DAOPublicacion.finalizate(this);
       }

       internal void actualizarPrecio(int oferta)
       {
           DAOPublicacion.actualizarOferta(this,oferta);
       }

       internal void ofertate(int oferta, Usuario usuario,String fecha)
       {
           DAOOferta.crearOferta(this, usuario, oferta,fecha);
       }

       internal int guardar()
       {
           return DAOPublicacion.guardar(this);
       }


       internal static void actualizarVencidas(DateTime dateTime)
       {
           DAOPublicacion.publicacionesVencidas(dateTime);
       }

       internal static void actualizarVencidas(DateTime dateTime, System.Windows.Forms.ProgressBar progressBar)
       {
           List<Publicacion> vencidas = DAOPublicacion.getPublicaciones().
               FindAll(p => !p.miEstado.cod_estadoPubli.Equals("F") && p.fecha_vencimiernto.CompareTo(dateTime) < 0 );

           progressBar.Visible = true;
           progressBar.Minimum = 0;
           progressBar.Maximum = vencidas.Count;
           progressBar.Value = 0;
           progressBar.Step = 1;

           foreach (Publicacion publi in vencidas)
           {
               publi.finalizar();
               if (!publi.esCompra()) // es subasta
               {

                   Oferta ganadora = Oferta.buscarGanadora(publi.cod_publicacion);
                   if( ganadora != null){
                       ganadora.ganadora = true;
                       ganadora.ponerGanadora();

                       Compra compraDeOfera = new Compra(ganadora.cod_publicacion,ganadora.userId,dateTime,1);
                       compraDeOfera.insertarCompra();

                       decimal comisionVenta = publi.comisionXventa(ganadora.monto);
                       decimal comisionEnvio = publi.comisionXenvio(ganadora.monto);

                       Factura unFactura = new Factura();
                       unFactura.cod_publicacion = publi.cod_publicacion;
                       unFactura.userId = publi.userId;
                       unFactura.fecha = dateTime;
                       unFactura.total = comisionEnvio + comisionVenta;
                       unFactura.forma_pago_desc = "Efectivo";
                       unFactura.insertarFactura();

                       ItemFactura unItem = new ItemFactura();
                       unItem.cantidad = 1;
                       unItem.monto = comisionVenta;
                       unItem.cod_concepto = Concepto.cod_por_venta();
                       unFactura.insertarItem(unItem);

                       if (comisionEnvio > 0 )
                       {
                           ItemFactura otroItem = new ItemFactura();
                           otroItem.cantidad = 1;
                           otroItem.monto = comisionEnvio;
                           otroItem.cod_concepto = Concepto.cod_por_envio();
                           unFactura.insertarItem(otroItem);
                       }
                    }   
                        
               }
               progressBar.PerformStep();
           }
           progressBar.Visible = false;
       }

       private decimal comisionXventa(decimal montoVenta)
       {
           decimal calculo = 0;
           Visibilidad unVisi = DAOVisibilidad.getVisibilidad(this.cod_visibilidad);
           if (unVisi != null)
           {
               calculo = montoVenta * unVisi.comision_vender;
           }
           return calculo;
       }

       private decimal comisionXenvio(decimal montoVenta)
       {
           decimal calculo = 0;
           Visibilidad unVisi = DAOVisibilidad.getVisibilidad(this.cod_visibilidad);
           if (unVisi != null)
           {
               if (unVisi.cod_tipo_comision_envio.Equals("F")) // F de fijo
               {
                   calculo = unVisi.valor_comision_envio;
               }
               else
               {
                   calculo = (unVisi.valor_comision_envio) * montoVenta;
               }
           }
           return calculo;

       }
    }
}
