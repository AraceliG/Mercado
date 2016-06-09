using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.ConexionBaseDeDatos.BO;

namespace MercadoEnvioFRBA.ConexionBaseDeDatos.DAO
{
    class DAOCliente
    {

        public List<Cliente> search(string nombre, string nroDoc, string email, string apellido)
        {
            List<Cliente> lc = new List<Cliente>();

            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(nroDoc) && String.IsNullOrEmpty(apellido)
                && String.IsNullOrEmpty(email))
            {

                String query = String.Format("SELECT c.dni, c.cod_tipo_doc,c.nombre, c.apellido,c.fecha_nacimiento,c.fechaCreacion,u.email,u.telefono,u.calle,u.num_calle,u.piso,u.depto,u.cod_postal FROM [GD1C2015].[NOTHING_IS_IMPOSIBLE].[USUARIO], NOTHING_IS_IMPOSSIBLE.USUARIO u , NOTHING_IS_IMPOSSIBLE.CLIENTE c  WHERE u.userId =  c.userId");
                return DB.ExecuteReader<Cliente>(query);
            }


            String base_query = String.Format("SELECT aeronave_id, f.fabricante_nombre, f.fabricante_id, m.modelo_nombre, [aeronave_matricula],[aeronave_modelo],[aeronave_kg_disponibles],[aeronave_fecha_alta],[aeronave_tipo_servicio],[aeronave_but_vent],[aeronave_but_pasill],[aeronave_fecha_bajadefinitiva],[aeronave_estado] FROM [GD2C2015].[SQLOVERS].[AERONAVE], SQLOVERS.MODELO m , SQLOVERS.FABRICANTE f WHERE m.modelo_id = aeronave_modelo AND m.modelo_fabricante = f.fabricante_id AND");
            if (!String.IsNullOrEmpty(matricula))
            {
                base_query += String.Format(" aeronave_matricula like '{0}%' AND", matricula);
            }

            if (!(fabricante == null))
            {
                base_query += String.Format(" f.fabricante_nombre like '{0}%' AND", fabricante);
            }

            if (!(modelo == null))
            {
                base_query += String.Format(" m.modelo_nombre LIKE '{0}%' AND", modelo);
            }

            if (!String.IsNullOrEmpty(peso))
            {
                base_query += String.Format(" aeronave_kg_disponibles = '{0}' AND", peso);
            }

            base_query = base_query.Substring(0, base_query.Length - 3);

            return DB.ExecuteReader<Aeronave>(base_query);
        }

    }
}
