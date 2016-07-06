using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAORubro
    {
        public static List<Rubro> devolverTodos()
        {
            List<Rubro> rubros = new List<Rubro>();
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT  R.COD_RUBRO, R.DESCRIPCION_LARGA FROM NOTHING_IS_IMPOSSIBLE.RUBRO R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rubro rubro = new Rubro();
                    rubro.cod_rubro = (Decimal)lector["cod_rubro"];
                    rubro.descripcion_larga = (String)lector["descripcion_larga"];

                    rubros.Add(rubro);
                }
            }
            return rubros;

        }
    }
}
