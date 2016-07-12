using MercadoEnvioFRBA.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                lector.Close();
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
     
        internal static decimal comosionPorVenta(decimal cod_visibilidad)
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            paramList.Add(new SqlParameter("@cod_visibilidad", cod_visibilidad));

            MessageBox.Show("hasta aca llega y el codigo es " + cod_visibilidad + "", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_VISIBILIDAD,COMISION_VENDER FROM NOTHING_IS_IMPOSSIBLE.Visibilidad WHERE COD_VISIBILIDAD=@cod_visibilidad", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Visibilidad unVisibilidad = new Visibilidad();
                    unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    unVisibilidad.comision_vender = (decimal)lector["comision_vender"];
                    visibilidades.Add(unVisibilidad);
                }
                lector.Close();
            }
            MessageBox.Show("hasta aca llega y el codigo la comision es " + visibilidades.Count + "", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return visibilidades[0].comision_vender;


        }

        internal static Decimal comisionPorEnvio(decimal cod_visibilidad)
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();

            paramList.Add(new SqlParameter("@cod_visibilidad", cod_visibilidad));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_VISIBILIDAD,VALOR_COMISION_ENVIO FROM NOTHING_IS_IMPOSSIBLE.Visibilidad WHERE COD_VISIBILIDAD=@cod_visibilidad", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Visibilidad unVisibilidad = new Visibilidad();
                    unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    unVisibilidad.valor_comision_envio = (decimal)lector["valor_comision_envio"];
                    visibilidades.Add(unVisibilidad);
                }
                lector.Close();
            }
            return visibilidades[0].valor_comision_envio;
        }

        internal static Visibilidad getVisibilidad(decimal cod_visibilidad)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_visibilidad", cod_visibilidad));

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.Visibilidad WHERE cod_visibilidad =@cod_visibilidad", "T", paramList);
            
            Visibilidad unVisibilidad = new Visibilidad();
            if (lector.HasRows)
            {
                lector.Read();
                unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                unVisibilidad.descripcion = (string)lector["descripcion"];
                unVisibilidad.comision_publicar = (decimal)lector["comision_publicar"];
                unVisibilidad.comision_vender = (decimal)lector["comision_vender"];
                unVisibilidad.permite_envios = (bool)lector["permite_envios"];
                unVisibilidad.cod_tipo_comision_envio = (string)lector["cod_tipo_comision_envio"];
                unVisibilidad.valor_comision_envio = (decimal)lector["valor_comision_envio"];
                unVisibilidad.baja = (bool)lector["baja"];
                lector.Close();
            }
            else
            {
                unVisibilidad = null;
            }

            return unVisibilidad;
        }

          public static List<Visibilidad> getVisibilidades() 
        { 
        List<Visibilidad> visibilidades = new List<Visibilidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_VISIBILIDAD,descripcion FROM NOTHING_IS_IMPOSSIBLE.Visibilidad", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Visibilidad unVisibilidad = new Visibilidad();
                    unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    unVisibilidad.descripcion = (String)lector["descripcion"];
                    visibilidades.Add(unVisibilidad);
                }
            } lector.Close();
            return visibilidades;
        }
       
         internal static Decimal getComisionVisibilidadPorDescripcion(string visibilidad)
        {

           
            List<Visibilidad> visibilidades = new List<Visibilidad>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@descrip",visibilidad));
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT COD_VISIBILIDAD,descripcion,comision_publicar FROM NOTHING_IS_IMPOSSIBLE.Visibilidad where descripcion=@descrip", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Visibilidad unVisibilidad = new Visibilidad();
                    unVisibilidad.cod_visibilidad = (decimal)lector["cod_visibilidad"];
                    unVisibilidad.descripcion = (String)lector["descripcion"];
                    unVisibilidad.comision_publicar = (Decimal)lector["comision_publicar"];
                    visibilidades.Add(unVisibilidad);
                } lector.Close();
            } 
             return visibilidades[0].comision_publicar;
        }
    }

    }

