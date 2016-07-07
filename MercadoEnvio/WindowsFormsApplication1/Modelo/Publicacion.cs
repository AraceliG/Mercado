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
           return DAOPublicacion.tieneStockPublicacion(this,cantidadComprada);
       }

       internal void facturar(Int32 stock)
       {
           DAOPublicacion.generarFactura(this,stock);
       }


       internal Decimal montoDeVenta()
       {
           return montoVenta=this.precio * DAOVisibilidad.comosionPorVenta(DAOPublicacion.obtenerVisibilidad(this));
          
       }

       internal Decimal montoDeEnvio()
       {

           return montoEnvio = DAOVisibilidad.comosionPorEnvio(DAOPublicacion.obtenerVisibilidad(this));
          
       }

       internal Decimal totalFactura()
       {
           return montoEnvio + montoEnvio;
       }

       internal void documentarCompra(Usuario usuario,int stock)
       {
           DAOCompra.documentarCompra(this, stock,usuario);
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

       internal void ofertate(int oferta, Usuario usuario)
       {
           DAOOferta.crearOferta(this, usuario, oferta);
       }
    }
}
