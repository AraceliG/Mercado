using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    unPubli.cod_publicacion = (Int32)lector["cod_publicacion"];
                    unPubli.cod_tipo_publicacion = (string)lector["cod_tipo_publicacion"];
                    unPubli.fecha_inicio = Convert.ToDateTime(lector["fecha_inicio"]);
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);
                    unPubli.stock = (decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.descripcion = (string)lector["descripcion"];
                    unPubli.acepta_preguntas = (bool) lector["acepta_preguntas"];
                    unPubli.ofrece_envios = (bool) lector["acepta_preguntas"];
                    unPubli.miEstado = CambioEstado.getEstado((string)lector["cod_estadoPubli"]);

                    if (DBNull.Value != lector["costo"])
                        unPubli.costo =  (decimal) lector["costo"]; 
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

                    unPubli.cod_publicacion = (Int32)lector["cod_publicacion"];
                    unPubli.cod_tipo_publicacion = (string)lector["cod_tipo_publicacion"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);
                    unPubli.stock = (decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.descripcion = (string)lector["descripcion"];
                    unPubli.acepta_preguntas = (bool)lector["acepta_preguntas"];
                    unPubli.ofrece_envios = (bool)lector["acepta_preguntas"];
                    unPubli.miEstado = CambioEstado.getEstado((string)lector["cod_estadoPubli"]);
                    unPubli.cod_visibilidad = (decimal)lector["cod_visibilidad"];

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

        public static List<Publicacion> getPublicacionPorEstado() {


            List<Publicacion> publis = new List<Publicacion>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT P.COD_PUBLICACION,P.STOCK,P.PRECIO,P.USERID,P.FECHA_INICIO,P.FECHA_VENCIMIERNTO FROM NOTHING_IS_IMPOSSIBLE.PUBLICACION P WHERE (P.COD_ESTADOPUBLI='A' OR P.COD_ESTADOPUBLI='P')", "T", new List<SqlParameter>());
            List<Cliente> publicacionesPorEstado = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                      unPubli.stock = (decimal)lector["stock"];
                      unPubli.precio = (decimal)lector["precio"];
                      unPubli.userId = (Decimal)lector["userId"];
                      unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                      unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;

        
        }

        public static List<Publicacion> getPublicacionesPorVisibilidad() {

            List<Publicacion> publis = new List<Publicacion>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT cod_publicacion,userId,fecha_inicio,fecha_vencimiernto,stock,precio FROM Publicacion P inner join Visibilidad V on P.cod_visibilidad=V.cod_visibilidad Order by V.comision_publicar desc ", "T", new List<SqlParameter>());
            List<Cliente> publicacionesPorEstado = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Publicacion unPubli = new Publicacion();
                    unPubli.cod_publicacion = (Decimal)lector["cod_publicacion"];
                    unPubli.stock = (decimal)lector["stock"];
                    unPubli.precio = (decimal)lector["precio"];
                    unPubli.userId = (Decimal)lector["userId"];
                    unPubli.fecha_inicio = (DateTime)lector["fecha_inicio"];
                    unPubli.fecha_vencimiernto = Convert.ToDateTime(lector["fecha_vencimiernto"]);

                    publis.Add(unPubli);
                }
            }
            return publis;
        
        }

        public static List<Publicacion> getPublicacionesOrdenadas() {

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
                    unPubli.stock = (decimal)lector["stock"];
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
    }
}
