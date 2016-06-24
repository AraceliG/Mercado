using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Datos;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class BuscadorCliente : Form
    {
         

        private void Buscador_Load(object sender, EventArgs e)
        {
            

        }
        
        public BuscadorCliente()
        {
            InitializeComponent();
            //listaClientes = new List<Cliente>();
            //dao = new DAOCliente();
        }

        //private DAOCliente dao;
        //private List<Cliente> listaClientes { get; set; }
          

        private void button_buscar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

      /*  private string consulta()
        {
            string conslt;
            string filtro = "";

            //"UPPER(EMAIL) LIKE UPPER('%" + textBox_mail.Text + "%')"

            if (textBox_nombre.Text != "" && textBox_nroDoc.Text != "" && textBox_email.Text != "" && textBox_apellido.Text != "")
            {
               return conslt = "SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE UPPER(EMAIL) LIKE UPPER('%" + textBox_email.Text + "%') AND UPPER(NOMBRE) LIKE UPPER('%" + textBox_nombre.Text + "%') AND UPPER(APELLIDO) LIKE UPPER('%" + textBox_apellido.Text + "%') AND DNI='" + textBox_nroDoc.Text + "'";
            }
            else
            {

                conslt = "SELECT * FROM NOTHING_IS_IMPOSSIBLE.USUARIO WHERE";
                

                if (textBox_nombre.Text != "")
                {
                    filtro += "UPPER(NOMBRE) LIKE UPPER('%" + textBox_nombre.Text + "%')";
                }

                if (textBox_apellido.Text != "")
                {
                    filtro += (filtro != "") ? " AND " : "";
                    filtro += "UPPER(APELLIDO) LIKE UPPER('%" + textBox_apellido.Text + "%')";

                }


                if (textBox_email.Text != "")
                {
                    filtro += (filtro != "") ? " AND " : "";
                    filtro += "UPPER(MAIL) LIKE UPPER('%" + textBox_email.Text + "%')";

                }

                if (textBox_nroDoc.Text != "")
                {
                    filtro += (filtro != "") ? " AND " : "";
                    filtro += "DNI = " + textBox_nroDoc.Text + "";
                }

                if (filtro != "")
                {
                    return conslt += " WHERE " + filtro;
                }

                else
                {
                    MessageBox.Show("INGRESE UN CRITERIO DE BÚSQUEDA POR FAVOR.", "Error de criterio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    
        */

        public void actualizarGrilla()

        {

            // WHERE UPPER(EMAIL) LIKE UPPER('%" + textBox_email.Text + "%') AND AND DNI= '" + textBox_nroDoc.Text + "'"
            //solo busca en tabla cliente por nombre y apellido, no por dni ni por email
            //no busca nada de tabla usuarios y deberia devolver esos campos también
           SqlCommand cm= new SqlCommand();
            cm.Connection= AccesoBaseDeDatos.GetConnection();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "SELECT C.DNI,T.DESCRIPCION,C.NOMBRE,C.APELLIDO,C.FECHA_NACIMIENTO,C.FECHACREACION,U.EMAIL,U.TELEFONO,U.CALLE,U.NUM_CALLE, U.PISO,U.DEPTO,U.COD_POSTAL FROM NOTHING_IS_IMPOSSIBLE.CLIENTE C,NOTHING_IS_IMPOSSIBLE.USUARIO U,NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO T WHERE NOMBRE LIKE ('%" + textBox_nombre.Text + "%') AND APELLIDO LIKE ('%" + textBox_apellido.Text + "%') AND EMAIL LIKE('%" + textBox_email.Text + "%')";
            cm.CommandText += "AND C.USERID=U.USERID AND C.COD_TIPO_DOC=T.COD_TIPO_DOC";
            //cm.CommandText += "AND C.DNI'" + (textBox_nroDoc.Text) + "'";
            cm.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);

            da.Fill(dt);
            dataGridView.DataSource = dt;


        }
    }
}

