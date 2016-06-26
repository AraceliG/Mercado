﻿using MercadoEnvioFRBA.Modelo;
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

        internal static int guardar(Visibilidad visibilidad)
        {
            string noQuery = "";
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@descripcion", visibilidad.descripcion));
            ListaParametros.Add(new SqlParameter("@comision_publicar", visibilidad.comision_publicar));
            ListaParametros.Add(new SqlParameter("@comision_vender", visibilidad.comision_vender));
            ListaParametros.Add(new SqlParameter("@permite_envios", visibilidad.permite_envios));
            ListaParametros.Add(new SqlParameter("@cod_tipo_comision_envio", visibilidad.cod_tipo_comision_envio));
            ListaParametros.Add(new SqlParameter("@valor_comision_envio", visibilidad.valor_comision_envio));
            ListaParametros.Add(new SqlParameter("@baja", "0"));

            if (visibilidad.cod_visibilidad == 0) {
                noQuery = "INSERT INTO NOTHING_IS_IMPOSSIBLE.Visibilidad " +
                               "(descripcion " +
                               ",comision_publicar " +
                               ",comision_vender " +
                               ",permite_envios " +
                               ",cod_tipo_comision_envio " +
                               ",valor_comision_envio " +
                               ",baja) " +
                         "VALUES " +
                               "(@descripcion " + 
                               ",@comision_publicar " +
                               ",@comision_vender " +
                               ",@permite_envios " +
                               ",@cod_tipo_comision_envio " +
                               ",@valor_comision_envio " +
                               ",@baja)";
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@cod_visibilidad", visibilidad.cod_visibilidad));
                noQuery = "UPDATE NOTHING_IS_IMPOSSIBLE.Visibilidad "+
                       "SET descripcion = @descripcion "+
                          ",comision_publicar = @comision_publicar "+
                          ",comision_vender = @comision_vender "+
                          ",permite_envios = @permite_envios "+
                          ",cod_tipo_comision_envio = @cod_tipo_comision_envio "+
                          ",valor_comision_envio = @valor_comision_envio "+
                          ",baja = @baja "+
                     "WHERE cod_visibilidad = @cod_visibilidad ";
            }


            return AccesoBaseDeDatos.WriteInBase(noQuery, "T", ListaParametros);
          
        }
    }
}

