using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvioFRBA.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace MercadoEnvioFRBA.Datos.DAO
{
    class DAOCliente
    {

        public static List<Cliente> devolverUsuarios()
        {

            SqlDataReader lector = AccesoBaseDeDatos.GetDataReader("SELECT C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO, C.FECHACREACION,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC", "T", new List<SqlParameter>());

            List<Cliente> clienteList = new List<Cliente>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {

                    Cliente cliente = new Cliente();

                    //en verde todos a los que se le debe solucionar el problema de tipos, compatibilidad
                    cliente.nombre = (string)lector["nombre"];
                    cliente.apellido = (string)lector["apellido"];
                    cliente.mail = (string)lector["email"];
                    cliente.dni = (int)(decimal)lector["dni"];
                    cliente.calle = (string)lector["calle"];
                    cliente.telefono = (string)lector["telefono"];
                    cliente.fechaNacimiento = (DateTime)lector["fecha_nacimiento"];
                    cliente.tipo_doc = (string)lector["descripcion"];
                    cliente.fechaCreacion = (DateTime)lector["fechaCreacion"];
                    //cliente.password = (string)lector["pass"];
                    //cliente.username = (string)lector["username"];
                    // cliente.habilitado = (int)(decimal)lector["habilitado"];
                    //cliente.cantFallidos = (int)(decimal)lector["user_nro_intentos"];
                    cliente.rol = (string)lector["nombre"];
                    cliente.calle = (string)lector["calle"];
                    cliente.num_calle = (int)(decimal)lector["num_calle"];
                    cliente.depto = (string)lector["calle"];
                    cliente.cod_postal = (string)lector["cod_postal"];
                    //cliente.baja = (int)(decimal)lector["baja"];
                    cliente.piso = (int)(decimal)lector["piso"];
                    //cliente.reputacion= (int)(decimal)lector["reputacion"];
                    //cliente.userId = (int)(decimal)lector["userId"];

                    clienteList.Add(cliente);
                }
            }
            return clienteList;
        }


        public static List<Cliente> AplicarFiltro(ClienteBuscador filtro)
        {
            //con datos presisos funciona solamente
            //no me toma los like
            //LIKE '*' + @DESCRIPCION + '*' según busque en internet

            string sql = @"SELECT C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO, C.FECHACREACION,U.EMAIL, U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC AND (C.NOMBRE LIKE '%' + @nombre + '%') AND (C.APELLIDO LIKE '%' + @apellido + '%') AND (U.EMAIL LIKE '%' + @email + '%')";

            List<Cliente> list = new List<Cliente>();

            SqlCommand cmd = new SqlCommand(sql, AccesoBaseDeDatos.GetConnection());

            if (string.IsNullOrEmpty(filtro.nombre))
                cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@nombre", filtro.nombre);

            cmd.Parameters.AddWithValue("@apellido", string.IsNullOrEmpty(filtro.apellido) ? (object)DBNull.Value : filtro.apellido);
            cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(filtro.apellido) ? (object)DBNull.Value : filtro.email);

            cmd.Parameters.AddWithValue("@dni", filtro.dni);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(obtenerCliente(reader));
            }

            return list;
        }

        private static Modelo.Cliente obtenerCliente(SqlDataReader reader)
        {
            Cliente client = new Cliente();

            client.dni = Convert.ToInt32(reader["dni"]);
            client.apellido = Convert.ToString(reader["apellido"]);
            client.nombre = Convert.ToString(reader["nombre"]);
            client.mail = Convert.ToString(reader["email"]);

            return client;
        }

    }



}
