using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Presentacion;
using System.Web;
using MercadoEnvioFRBA.Datos.DAO;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Presentacion.ComprarOfertar;
using MercadoEnvioFRBA.Presentacion.ABM_Usuario;

namespace MercadoEnvioFRBA.ComprarOfertar
    
{
    public partial class Form1 : FormBaseUTN
    {
        private List<Rubro> rubros0;
        private List<Rubro> rubros1;
        private List<Rubro> rubros2;
        private List<Rubro> rubros3;
        private Usuario usuario;
        
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridPublicacion.AutoGenerateColumns = false;
            dataGridPublicacion.MultiSelect = false;
            rubros0 = DAORubro.devolverTodos();
            rubros1 = DAORubro.devolverTodos();
            rubros2 = DAORubro.devolverTodos();
            rubros3 = DAORubro.devolverTodos();
            comboBox_rubro0.DataSource = rubros0;
            comboBox_rubro0.DisplayMember = "descripcion_larga";
            comboBox_rubro2.DataSource = rubros1;
            comboBox_rubro2.DisplayMember = "descripcion_larga";

            comboBox_rubro1.DataSource = rubros2;
            comboBox_rubro1.DisplayMember = "descripcion_larga";

            comboBox_rubro3.DataSource = rubros3;
            comboBox_rubro3.DisplayMember = "descripcion_larga";

            comboBox_rubro0.SelectedIndex = -1;
           comboBox_rubro1.SelectedIndex = -1;
           comboBox_rubro2.SelectedIndex = -1;
           comboBox_rubro3.SelectedIndex = -1;


            cargarGrilla();
            actualizarGrilla();

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colCodPublic = new DataGridViewTextBoxColumn();
            colCodPublic.DataPropertyName = "cod_publicacion";
            colCodPublic.HeaderText = "Codigo de Publicacion";
            colCodPublic.Width = 120;
            DataGridViewTextBoxColumn colStock = new DataGridViewTextBoxColumn();
            colStock.DataPropertyName = "stock";
            colStock.HeaderText = "Stock";
            colStock.Width = 120;
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Width = 120;
            DataGridViewTextBoxColumn colVendedor = new DataGridViewTextBoxColumn();
            colVendedor.DataPropertyName = "userId";
            colVendedor.HeaderText = "identificador del vendedor";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaInicio.DataPropertyName = "fecha_inicio";
            colFechaInicio.HeaderText = "Fecha de Inicio";
            colVendedor.Width = 120;
            DataGridViewTextBoxColumn colFechaFin = new DataGridViewTextBoxColumn();
            colFechaFin.DataPropertyName = "fecha_vencimiernto";
            colFechaFin.HeaderText = "Fecha de Vencimiento";
            colFechaFin.Width = 120;

            dataGridPublicacion.Columns.Add(colCodPublic);
            dataGridPublicacion.Columns.Add(colStock);
            dataGridPublicacion.Columns.Add(colPrecio);
            dataGridPublicacion.Columns.Add(colVendedor);
            dataGridPublicacion.Columns.Add(colFechaInicio);
            dataGridPublicacion.Columns.Add(colFechaFin);
        }

        private void comboBox_rubro1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text.Length == 0 && comboBox_rubro1.SelectedItem == null && comboBox_rubro0.SelectedItem==null && comboBox_rubro2.SelectedItem == null && comboBox_rubro3.SelectedItem==null)
            {
                MessageBox.Show("Debe elegir un criterio de búsqueda", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {  List<Publicacion> publis= new List<Publicacion>();
                 List<Publicacion> publicaciones = DAOPublicacion.cumpleConFiltros(txt_desc.Text, comboBox_rubro0.SelectedText, comboBox_rubro1.SelectedText, comboBox_rubro2.SelectedText, comboBox_rubro3.SelectedText);
                  dataGridPublicacion.DataSource = publicaciones;
                MessageBox.Show("Su busqueda ha finalizado con éxito!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void actualizarGrilla()
        {
            List<Publicacion> publicaciones = DAOPublicacion.devolverPublicaciones();
            dataGridPublicacion.DataSource = publicaciones;
        }

        private void comboBox_rubro2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_rubro0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (usuario.tusComprasSinCalificar().Count <= 3)
            {

                if (dataGridPublicacion.RowCount != 0)
                {
                    Publicacion publi = (Publicacion)dataGridPublicacion.CurrentRow.DataBoundItem;

                    if (!publi.laHizoUsuario(usuario))
                    {
                        if (!publi.estaPausada())
                        {
                            if (publi.esCompra())
                            {
                                this.Hide();
                                FormCompra buscarRol = new FormCompra(publi, usuario);
                                buscarRol.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("La publicacion es para realizar OFERTAS a SUBASTAS ", "Publicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("La publicacion se encuentra pausada no puede comprar/ofertar", "Publicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usted no puede auto comprarse/ ofertarse", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe elegir una fila de su tabla resultado de su búsqueda", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            { MessageBox.Show("No podrá comprar ni ofertar hasta que no califique sus pendientes ", "Calificaciones Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }


        private void btn_ofertar_Click(object sender, EventArgs e)
        {
            if (usuario.tusComprasSinCalificar().Count <= 3)
            {

                if (dataGridPublicacion.RowCount != 0)
                {
                    Publicacion publi = (Publicacion)dataGridPublicacion.CurrentRow.DataBoundItem;

                    if (!publi.laHizoUsuario(usuario))
                    {
                        if (!publi.estaPausada())
                        {
                            if (!publi.esCompra())
                            {
                                this.Hide();
                                FormOfertaDeSubasta buscarRol = new FormOfertaDeSubasta(publi, usuario);
                                buscarRol.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("La publicacion es para realizar COMPRAS", "Publicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("La publicacion se encuentra pausada no puede comprar/ofertar", "Publicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usted no puede auto comprarse/ ofertarse", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe elegir una fila de su tabla resultado de su búsqueda", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else {
                MessageBox.Show("No podrá comprar ni ofertar hasta que no califique sus pendientes ", "Calificaciones Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Publicacion publi = (Publicacion)dataGridPublicacion.CurrentRow.DataBoundItem;

            if (publi.esDeCliente())
            {
                this.Hide();
                DatosCliente datos = new DatosCliente(publi.userId);
                datos.ShowDialog();
                this.Show();
            }

            if (publi.esDeEmpresa()) 
            {
                this.Hide();
                DatosEmpres datos = new DatosEmpres(publi.userId);
                datos.ShowDialog();
                this.Show();
            }


        }


       
    }
}
