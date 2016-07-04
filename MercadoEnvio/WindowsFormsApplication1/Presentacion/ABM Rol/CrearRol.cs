using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvioFRBA.Modelo;
using MercadoEnvioFRBA.Datos.DAO;
using System.Text.RegularExpressions;

namespace MercadoEnvioFRBA.Presentacion.ABM_Rol
{
    public partial class CrearRol : FormBaseUTN
    {

        private List<Funcionalidad> func;

        public CrearRol()
        {
            InitializeComponent();
            this.func=new List<Funcionalidad>();
        }

        private void CrearRol_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        public void actualizarGrilla() {
            List<Funcionalidad> listaDeRoles = new List<Funcionalidad>();
            listaDeRoles = DAOFuncionalidad.buscarFuncionalidades();
            dataGridFuncionalidad.DataSource = listaDeRoles;
        
        }

       
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (dataGridFuncionalidad.RowCount != 0)
            {
                if (this.existeFuncionalidad())
                {

                    MessageBox.Show("Esa funcionalidad ya fue agregada", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
                    Funcionalidad funcionalidad= new Funcionalidad();
                    funcionalidad.nombre = f.nombre.Replace(" ", "").Replace("/","");
                    funcionalidad.cod_funcionalidad = f.cod_funcionalidad;
                    func.Add(funcionalidad);
                    MessageBox.Show("Su funcionalidad ha sido agregada con exito", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una funcionalidad", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private bool existeFuncionalidad()
        {
            Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
           return func.Contains(f);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dataGridFuncionalidad.RowCount != 0)
            {
                if (this.existeFuncionalidad())
                {  
                    Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
                    func.Remove(f);
                    MessageBox.Show("la funcionalidad fue eliminada", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("esa funcionalidad no existe para ese  rol", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una funcionalidad", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_modificarRol_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            if (textBox_nombreRol.Text.Length == 0)
            {
                errorProvider_nombreRol.SetError(textBox_nombreRol, "DEBE INGRESAR EL NOMBRE DEL ROL A CREAR");
                vacio = true;
            }
            else { errorProvider_nombreRol.Clear(); }
            if (vacio) return;
            Rol nuevoR = new Rol();
            nuevoR.nombre = textBox_nombreRol.Text;
            nuevoR.funcionalidades = func;
            DAORol.crearRol(nuevoR);
            MessageBox.Show("el rol ha sido creado exitosamente", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

        }

        private void dataGridFuncionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
