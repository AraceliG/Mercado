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
                    unPubli.cod_publicacion = (decimal)lector["cod_publicacion"];
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

                    unPubli.cod_publicacion = (decimal)lector["cod_publicacion"];
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
    }
}
