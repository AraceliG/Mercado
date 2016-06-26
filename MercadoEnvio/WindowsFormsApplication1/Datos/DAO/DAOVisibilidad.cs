using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOVisibilidad
    {
        internal static List<Visibilidad> getVisibilidadesQueCumplenCon(string filtro)
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Visibilidad WHERE " + filtro , "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Visibilidad unVisibilidad = new Visibilidad();
                    unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    unVisibilidad.descripcion = (string)lector["descripcion"];
                    unVisibilidad.comision_publicar = (decimal)lector["comision_publicar"];
                    unVisibilidad.comision_vender = (decimal)lector["comision_vender"];
                    unVisibilidad.permite_envios = (bool)lector["permite_envios"];
                    unVisibilidad.cod_tipo_comision_envio = (string)lector["cod_tipo_comision_envio"];
                    unVisibilidad.valor_comision_envio = (decimal)lector["valor_comision_envio"];
                    unVisibilidad.baja = (bool)lector["baja"];
                    visibilidades.Add(unVisibilidad);
                }
            }
            return visibilidades;
        }

        internal static void darDeBaja(Visibilidad visibilidad)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@cod_visibilidad", visibilidad.cod_visibilidad));
            listaParametros.Add(new SqlParameter("@baja", true));

            AccesoBaseDeDatos.WriteInBase("update NOTHING_IS_IMPOSSIBLE.Visibilidad set baja=@baja where cod_visibilidad=@cod_visibilidad", "T", listaParametros);

        }

        internal static void guardar(Visibilidad visibilidad)
        {
            throw new NotImplementedException();
        }
    }
}
