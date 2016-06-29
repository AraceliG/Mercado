using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;
using System.Configuration;
using System.Data.SqlClient;
using MercadoEnvioFRBA.Datos;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;

namespace MercadoEnvioFRBA.ABM_Usuario
{
    public partial class FormularioCliente : FormUsuario
    {

        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTipoDocumentos()
        {
            //consulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT DESCRIPCION FROM NOTHING_IS_IMPOSSIBLE.TIPODOCUMENTO";
            cmd.Connection = AccesoBaseDeDatos.GetConnection();

            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //agrego
                    comboBox_tipoDoc.Items.Add(reader.GetString(0));
                }

                comboBox_tipoDoc.SelectedIndex = 0;
            }

            //libero
            reader.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_tipoDoc.Items.Count <= 0)
            {
                cargarTipoDocumentos();
            }
        }

        private void button_fecha_Click(object sender, EventArgs e)
        {
            Calendario frmCal = new Calendario();
            if (frmCal.ShowDialog() == DialogResult.Yes)
            {
                DateTime time = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

                if (frmCal.getFechaDateTime() < time)
                {
                    textBox_fecha.Text = frmCal.getFecha();
                }
                else
                {
                    MessageBox.Show("No es una fecha valida.", "Fecha De Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            frmCal.Dispose();  
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool vacio = false;

            if (textBox_nombre.Text.Length == 0)
            {
                errorProvider_nombre.SetError(textBox_nombre, "Por favor ingrese nombre");
                vacio = true;
            }
            else { errorProvider_nombre.Clear(); }

            if (textBox_apellido.Text.Length == 0)
            {
                errorProvider_ape.SetError(textBox_apellido, "Por favor ingrese apellido");
                vacio = true;
            }
            else { errorProvider_ape.Clear(); }

            if (comboBox_tipoDoc.Text.Length == 0)
            {
                errorProvider_tipo_doc.SetError(comboBox_tipoDoc, "Por favor ingrese tipo de documento");
                vacio = true;
            }
            else { errorProvider_tipo_doc.Clear(); }

            if (textBox_nroDoc.Text.Length == 0)
            {
                errorProvider_nro_doc.SetError(textBox_nroDoc, "Por favor ingrese dni");
                vacio = true;
            }
            else { errorProvider_nro_doc.Clear(); }

            if (vacio) return;

           if( this.fueCreadoCliente(Convert.ToInt32(textBox_nroDoc.Text),comboBox_tipoDoc.Text)){
               MessageBox.Show("El cliente ya fue creado.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           }else{
           if (this.existeUsername()){
               MessageBox.Show("Existe un usuario con ese username, por favor ingrese uno diferente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else{

               this.crearCliente();
               MessageBox.Show("se creo exitosamente al cliente!","Cliente",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
               
           }


        }

        private void crearCliente()
        { 
            Cliente cliente = new Cliente();
             cliente.apellido = textBox_apellido.Text;
            cliente.nombre = textBox_nombre.Text;
            cliente.dni = Int32.Parse(textBox_nroDoc.Text);
        //  cliente.fechaNacimiento = Convert.ToDateTime(textBox_fecha.Text);
            cliente.mail = textBox_mail.Text;
            cliente.calle = textBox_calle.Text;
            cliente.telefono = text_telefono.Text;
           //liente.fechaCreacion = Convert.ToDateTime(textBox1.Text);
            cliente.password = textBox_psw.Text;
            cliente.username = textBox_usuario.Text;
            cliente.calle = textBox_calle.Text;
          //cliente.num_calle = Convert.ToInt32(textBox_nro.Text);
            cliente.depto = textBox_depto.Text;
            cliente.cod_postal = textBox_cod_postal.Text;
          //cliente.piso = Convert.ToInt32(textBox_piso.Text);
            
            DAOCliente.crearCliente(cliente);

        }

private bool fueCreadoCliente(int dni,string tipoDoc)
{
    Cliente cliente = new Cliente();
    cliente.dni = dni;
    cliente.tipo_doc = tipoDoc;
   return DAOCliente.existeCliente(cliente);

}


                
            
            }
        }
