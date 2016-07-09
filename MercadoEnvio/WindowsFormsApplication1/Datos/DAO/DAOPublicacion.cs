using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOPublicacion
    {
        internal static List<Publicacion> getPublicacionesDe(decimal userId)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@userId", userId));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Publicacion WHERE userId = @userId", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (decimal)lector["cod_publicacion"];
                    unPubli.cod_tipo_publicacion = (string)lector["cod_tipo_publicacion"];
                    unPubli.fecha_inicio = Convert.ToDateTime(lector["fecha_inicio"]);
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);
                    unPubli.stock = (Decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.descripcion = (string)lector["descripcion"];
                    unPubli.acepta_preguntas = (bool)lector["acepta_preguntas"];
                    unPubli.ofrece_envios = (bool)lector["acepta_preguntas"];
                    unPubli.miEstado = CambioEstado.getEstado((string)lector["cod_estadoPubli"]);

                    if (DBNull.Value != lector["costo"])
                        unPubli.costo = (decimal)lector["costo"];
                    //unPubli.cod_visibilidad =

                    publicaciones.Add(unPubli);
                }
            }
            return publicaciones;
        }

        internal static Publicacion getPublicacion(decimal cod_publicacion)
        {
            Publicacion unPubli = new Publicacion();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_publicacion", cod_publicacion));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Publicacion WHERE cod_publicacion = @cod_publicacion", "T", paramList);
            if (lector.HasRows)
            {
                lector.Read();

                unPubli.cod_publicacion = (decimal)lector["cod_publicacion"];
                unPubli.cod_tipo_publicacion = (string)lector["cod_tipo_publicacion"];
                unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);
                unPubli.stock = (Decimal)lector["stock"];
                unPubli.precio = (decimal)lector["precio"];
                unPubli.descripcion = (string)lector["descripcion"];
                unPubli.acepta_preguntas = (bool)lector["acepta_preguntas"];
                unPubli.ofrece_envios = (bool)lector["acepta_preguntas"];
                unPubli.miEstado = CambioEstado.getEstado((string)lector["cod_estadoPubli"]);
                unPubli.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                unPubli.userId = (Decimal) lector["userId"];

                if (DBNull.Value != lector["costo"])
                    unPubli.costo = (decimal)lector["costo"];

            }
            return unPubli;
        }

        internal static DataTable getPublicacionesConfiltro(string filtro)
        {
            string query = @"SELECT * from ( SELECT p.cod_publicacion
					  , t.descripcion as 'tipo_publicacion'      
					  , convert (date, p.fecha_inicio) as 'fecha_inicio'
					  , convert (date, p.fecha_vencimiernto ) as 'fecha_vencimiernto'
					  , p.stock
					  , p.precio
					  , p.costo
					  , v.descripcion as 'visibilidad'
					  , e.descripcion as 'estado'
					  , p.descripcion
					  , p.acepta_preguntas
					  , p.ofrece_envios
					  , p.userId
				  FROM NOTHING_IS_IMPOSSIBLE.Publicacion p
					inner join NOTHING_IS_IMPOSSIBLE.TipoPublicacion t
						on p.cod_tipo_publicacion = t.cod_tipo_publicacion
					inner join NOTHING_IS_IMPOSSIBLE.visibilidad v
						on p.cod_visibilidad = v.cod_visibilidad
					inner join NOTHING_IS_IMPOSSIBLE.EstadoPubli e
						on p.cod_estadoPubli= e.cod_estadoPubli ) publi";

            if (filtro != null)
                query = query + " Where " + filtro;

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(query, "T", new List<SqlParameter>());
            DataTable dt = new DataTable("listado");

            if (lector.HasRows)
                dt.Load(lector);

            return dt;
        }

        public static List<Publicacion> getPublicacionPorEstado()
        {


            List<Publicacion> publis = new List<Publicacion>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.COD_PUBLICACION,P.STOCK,P.PRECIO,P.USERID,P.FECHA_INICIO,P.FECHA_VENCIMIERNTO FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE (P.COD_ESTADOPUBLI='A' OR P.COD_ESTADOPUBLI='P')", "T", new List<SqlParameter>());
            List<Cliente> publicacionesPorEstado = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.stock = (Decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.userId = (Decimal)lector["userId"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;


        }

        public static List<Publicacion> getPublicacionesPorVisibilidad()
        {

            List<Publicacion> publis = new List<Publicacion>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT cod_publicacion,userId,fecha_inicio,fecha_vencimiernto,stock,precio FROM Publicacion P inner join Visibilidad V on P.cod_visibilidad=V.cod_visibilidad Order by V.comision_publicar desc ", "T", new List<SqlParameter>());
            List<Cliente> publicacionesPorEstado = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.stock = (Decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.userId = (Decimal)lector["userId"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;

        }

        public static List<Publicacion> getPublicacionesOrdenadas()
        {

            // se obtienen las publicaciones que estén habilitadas para el publico:activas y pausadas
            // y ordenadas por visibilidad

            List<Publicacion> publis = new List<Publicacion>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(" SELECT P.cod_publicacion,userId,fecha_inicio,fecha_vencimiernto,stock,precio FROM NOTHING_IS_IMPOSSIBLE.Publicacion P inner join NOTHING_IS_IMPOSSIBLE.Visibilidad V on P.cod_visibilidad=V.cod_visibilidad WHERE (P.COD_ESTADOPUBLI='A' OR P.COD_ESTADOPUBLI='P')Order by V.comision_publicar desc ", "T", new List<SqlParameter>());
            List<Cliente> publicacionesPorEstado = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.stock = (Decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.userId = (Decimal)lector["userId"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;
        }

        public static List<Publicacion> devolverPublicaciones()
        {
            List<Publicacion> lista = new List<Publicacion>();
            lista = getPublicacionesOrdenadas();
            return lista;
            //el paginado no lo voy a tener en cuenta
            // 

        }
        
        internal static bool cumpleFiltros(Publicacion publicacion, string descripcionPubli, string rubro0, string rubro1, string rubro2, string rubro3)
        {

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));

            String base_query = "SELECT P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId,R.descripcion_larga FROM NOTHING_IS_IMPOSSIBLE.Publicacion P, NOTHING_IS_IMPOSSIBLE.Rubro R,NOTHING_IS_IMPOSSIBLE.RubroPublicacion RP WHERE p.cod_publicacion=RP.cod_publicacion and p.cod_publicacion=@cod_publi";

            if (!String.IsNullOrEmpty(descripcionPubli))
            {
                listaParametros.Add(new SqlParameter("@desc_publi", descripcionPubli));
                base_query += " and p.descripcion=@desc_publi";
            }

            if (!String.IsNullOrEmpty(rubro0))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro0", rubro0));
                base_query += " and R.descripcion_larga=@pub_rubro0 ";
            }

            if (!String.IsNullOrEmpty(rubro1))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro1", rubro1));
                base_query += "and R.descripcion_larga=@pub_rubro1 ";
            }

            if (!String.IsNullOrEmpty(rubro2))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro2", rubro2));
                base_query += "and R.descripcion_larga=@pub_rubro2 ";
            }

            if (!String.IsNullOrEmpty(rubro3))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro3", rubro3));
                base_query += "and R.descripcion_larga=@pub_rubro3 ";
            }
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(base_query, "T", listaParametros);

            return createPublicacionListFromQuery(lector).Count >= 1;



        }

        private static List<Publicacion> createPublicacionListFromQuery(SqlDataReader lector)
        {
            List<Publicacion> publis = new List<Publicacion>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.stock = (Decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.userId = (Decimal)lector["userId"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;

        }

        public static List<Publicacion> cumpleConFiltros(string descripcionPubli, string rubro0, string rubro1, string rubro2, string rubro3)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            String condicionQuery1 = "";
            String condicionQuery2 = "";

            if (!String.IsNullOrEmpty(descripcionPubli))
            {
                listaParametros.Add(new SqlParameter("@desc_publi", descripcionPubli));
                condicionQuery1 += " and P.descripcion=@desc_publi ";
            }

            if (!String.IsNullOrEmpty(rubro0) || !String.IsNullOrEmpty(rubro1) || !String.IsNullOrEmpty(rubro2) || !String.IsNullOrEmpty(rubro3))
            {
                condicionQuery2 += ",NOTHING_IS_IMPOSSIBLE.Rubro R,NOTHING_IS_IMPOSSIBLE.RubroPublicacion RP WHERE PO.cod_publicacion=RP.cod_publicacion";
            }

            if (!String.IsNullOrEmpty(rubro0))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro0", rubro0));
                condicionQuery2 += " and R.descripcion_larga=@pub_rubro0 ";
            }
            if (!String.IsNullOrEmpty(rubro1))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro1", rubro1));
                condicionQuery2 += "and R.descripcion_larga=@pub_rubro1 ";
            }

            if (!String.IsNullOrEmpty(rubro2))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro2", rubro2));
                condicionQuery2 += "and R.descripcion_larga=@pub_rubro2 ";
            }

            if (!String.IsNullOrEmpty(rubro3))
            {
                listaParametros.Add(new SqlParameter("@pub_rubro3", rubro3));
                condicionQuery2 += "and R.descripcion_larga=@pub_rubro3 ";
            }
            

            String base_query = " select PO.cod_publicacion,PO.descripcion,PO.fecha_inicio,PO.fecha_vencimiernto,PO.stock,PO.precio,PO.USERID " +
            "FROM" +
 "(SELECT P.cod_publicacion,P.USERID,V.cod_visibilidad,P.descripcion,V.comision_publicar,fecha_inicio,fecha_vencimiernto,stock,precio" +
 " FROM NOTHING_IS_IMPOSSIBLE.Publicacion P inner join NOTHING_IS_IMPOSSIBLE.Visibilidad V on P.cod_visibilidad=V.cod_visibilidad WHERE (P.COD_ESTADOPUBLI='A' OR P.COD_ESTADOPUBLI='P')" +

           condicionQuery1 + ") PO" + condicionQuery2;

            base_query += " Order by PO.comision_publicar desc ";

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader(base_query, "T", listaParametros);

            return createPublicacionListFromQuery(lector);
        }

        public static bool hizoUsuarioPublicacion(Publicacion publicacion, Usuario usuario)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            listaParametros.Add(new SqlParameter("@cod_usuario", usuario.userId));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi AND P.USERID=@cod_usuario ", "T", listaParametros);
            return createPublicacionListFromQuery(lector).Count >= 1;
        }

        public static bool estaPausada(Publicacion publicacion)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT  P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi AND P.COD_ESTADOPUBLI='P' ", "T", listaParametros);
            return createPublicacionListFromQuery(lector).Count >= 1;
        }

        public static bool esCompra(Publicacion publicacion)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi AND P.COD_TIPO_PUBLICACION='C' ", "T", listaParametros);
            return createPublicacionListFromQuery(lector).Count >= 1;
            
        }
                
        internal static bool tieneStockPublicacion(Publicacion publicacion, int cantidadComprada)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            listaParametros.Add(new SqlParameter("@cantComprada", cantidadComprada));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi AND P.STOCK>=@cantComprada ", "T", listaParametros);
            return createPublicacionListFromQuery(lector).Count >= 1;
        }
        
        internal static decimal obtenerVisibilidad(Publicacion publicacion)
        {

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_PUBLICACION,COD_VISIBILIDAD FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION WHERE COD_PUBLICACION=@cod_publi ", "T", listaParametros);
            List<Publicacion> publis = new List<Publicacion>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    publis.Add(unPubli);
                }
            }

            return publis[0].cod_visibilidad;

            
        }

        internal static void actualizarStock(Publicacion publi, Decimal stock)
        {

            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publi.cod_publicacion));
            parameterList.Add(new SqlParameter("@stock_nuevo", stock));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.PUBLICACION SET STOCK=@stock_nuevo WHERE COD_PUBLICACION=@cod_publi", "T", parameterList);
        }

        internal static Decimal obtenerStock(Publicacion publicacion)
        {
             List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi", "T", listaParametros);
            return createPublicacionListFromQuery(lector)[0].stock;
        }
        
        internal static bool esFinStock(Publicacion publicacion)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.cod_publicacion,fecha_inicio,fecha_vencimiernto,stock,precio,userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi AND stock=0", "T", listaParametros);
            return createPublicacionListFromQuery(lector).Count>=1;
        }
        
        internal static void finalizate(Publicacion publi)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publi.cod_publicacion));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.PUBLICACION SET COD_ESTADOPUBLI='F' WHERE COD_PUBLICACION=@cod_publi", "T", parameterList);
        }
        
        internal static void actualizarOferta(Publicacion publicacion, int oferta)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", publicacion.cod_publicacion));
            parameterList.Add(new SqlParameter("@oferta", oferta));
            AccesoBaseDeDatos.WriteInBase("UPDATE NOTHING_IS_IMPOSSIBLE.PUBLICACION SET PRECIO=@oferta WHERE COD_PUBLICACION=@cod_publi", "T", parameterList);

        }

        internal static int guardar(Publicacion publicacion)
        {
            string noQuery = "";
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@userId", publicacion.userId));
            ListaParametros.Add(new SqlParameter("@cod_tipo_publicacion", publicacion.cod_tipo_publicacion));
            ListaParametros.Add(new SqlParameter("@fecha_inicio", publicacion.fecha_inicio));
            ListaParametros.Add(new SqlParameter("@fecha_vencimiernto", publicacion.fecha_vencimiernto));
            ListaParametros.Add(new SqlParameter("@stock", publicacion.stock));
            ListaParametros.Add(new SqlParameter("@precio", publicacion.precio));
            ListaParametros.Add(new SqlParameter("@costo", publicacion.costo));
            ListaParametros.Add(new SqlParameter("@cod_visibilidad", publicacion.cod_visibilidad));
            ListaParametros.Add(new SqlParameter("@cod_estadoPubli", publicacion.miEstado.cod_estadoPubli));
            ListaParametros.Add(new SqlParameter("@descripcion", publicacion.descripcion));
            ListaParametros.Add(new SqlParameter("@acepta_preguntas", publicacion.acepta_preguntas));
            ListaParametros.Add(new SqlParameter("@ofrece_envios", publicacion.ofrece_envios));

            if (publicacion.cod_publicacion == 0)
            {
                ListaParametros.Add(new SqlParameter("@cod_publicacion", proximoCod_publicacion()));
                noQuery = @"INSERT INTO NOTHING_IS_IMPOSSIBLE.Publicacion
                                   (cod_publicacion
                                   ,cod_tipo_publicacion
                                   ,userId
                                   ,fecha_inicio
                                   ,fecha_vencimiernto
                                   ,stock
                                   ,precio
                                   ,costo
                                   ,cod_visibilidad
                                   ,cod_estadoPubli
                                   ,descripcion
                                   ,acepta_preguntas
                                   ,ofrece_envios)
                             VALUES
                                   (@cod_publicacion
                                   ,@cod_tipo_publicacion
                                   ,@userId
                                   ,@fecha_inicio
                                   ,@fecha_vencimiernto
                                   ,@stock
                                   ,@precio
                                   ,@costo
                                   ,@cod_visibilidad
                                   ,@cod_estadoPubli
                                   ,@descripcion
                                   ,@acepta_preguntas
                                   ,@ofrece_envios)";
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@cod_publicacion", publicacion.cod_publicacion));
                noQuery = @"UPDATE NOTHING_IS_IMPOSSIBLE.Publicacion
                               SET cod_tipo_publicacion = @cod_tipo_publicacion
                                  ,userId = @userId
                                  ,fecha_inicio = @fecha_inicio
                                  ,fecha_vencimiernto = @fecha_vencimiernto
                                  ,stock = @stock
                                  ,precio = @precio
                                  ,costo = @costo
                                  ,cod_visibilidad = @cod_visibilidad
                                  ,cod_estadoPubli = @cod_estadoPubli
                                  ,descripcion = @descripcion
                                  ,acepta_preguntas = @acepta_preguntas
                                  ,ofrece_envios = @ofrece_envios
                             WHERE cod_publicacion = @cod_publicacion ";
            }


            return AccesoBaseDeDatos.WriteInBase(noQuery, "T", ListaParametros);
        }

        private static decimal proximoCod_publicacion()
        {
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("select max(cod_publicacion) as maximo from NOTHING_IS_IMPOSSIBLE.Publicacion", "T", new List<SqlParameter>());
            lector.Read();
            return 1 + (decimal)lector["maximo"];
        }


        internal static Decimal VendedorDePublicacion(decimal codPubli)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@cod_publi", codPubli));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.cod_publicacion,P.userId FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE P.COD_PUBLICACION=@cod_publi", "T", parameterList);
            List<Publicacion> publis = new List<Publicacion>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.userId = (Decimal)lector["userId"];
                    publis.Add(unPubli);
                }
            }
            return publis[0].userId;


        }
    }
}
