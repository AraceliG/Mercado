using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOCalificacion
    {
        internal static List<Calificacion> getCalificaciones()
        {
            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT * FROM NOTHING_IS_IMPOSSIBLE.ESTRELLAS","T", new List<SqlParameter>());

            List<Calificacion> califList = new List<Calificacion>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Calificacion calif = new Calificacion();
                    calif.cant_estrellas = (int)(decimal)lector["cant_estrellas"];
                    calif.descripcion = (string)lector["descripcion"];
                    califList.Add(calif);
                }
                lector.Close();
            }
            return califList;

        }
    }
}
