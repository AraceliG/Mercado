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
    public partial class AgregarFuncionalidades : FormBaseUTN
    {

        private List<Funcionalidad> func;
        public Rol rol { get; set; }
        private bool create;
        public String nombreAnteriorRol;
        public List<Funcionalidad> funcAnt;


        public AgregarFuncionalidades()
        {    
            this.create = true;
            InitializeComponent();
            func=new List<Funcionalidad>();
           
        }

        public AgregarFuncionalidades(Rol r)
        {
            create = false;
            this.rol = r;
            this.func = r.funcionalidades;
            
            InitializeComponent();

            textBox_nombreRol.Text = r.nombre;
            textBox_nombreRol.ReadOnly = true;
            dataGridFuncionalidad.DataSource = DAOFuncionalidad.buscarFuncionalidades();
            this.nombreAnteriorRol=r.nombre;
            this.funcAnt = DAORol.obtenerFuncionalidades(nombreAnteriorRol);


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
                if (dataGridFuncionalidad.RowCount != 0){
                    

                    Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.nombre = f.nombre;
                    funcionalidad.cod_funcionalidad = f.cod_funcionalidad;
                    if(!funcionalidad.existeEnRol(rol)){
                        funcionalidad.agregateA(rol);
                        MessageBox.Show("Su funcionalidad ha sido agregada con exito", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else { MessageBox.Show("la funcionalidad "+ funcionalidad.nombre +  "existe para el rol "+ rol.nombre +"", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                    else
                    {  MessageBox.Show("debe elegir una funcionalidad", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
                }


        private bool existeFuncionalidad()
        {
              Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
              //if (func == null)
              //{
                //  this.func = DAORol.obtenerFuncionalidades(nombreAnteriorRol);
                  //return func.Contains(f);
             // }
              //else
              //{
                  return func.Contains(f);
              //}
}
           
       

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dataGridFuncionalidad.RowCount != 0)
            {
                Funcionalidad f = (Funcionalidad)dataGridFuncionalidad.CurrentRow.DataBoundItem;
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.nombre = f.nombre;
                    funcionalidad.cod_funcionalidad = f.cod_funcionalidad;
                    if(funcionalidad.existeEnRol(rol)){
                        funcionalidad.eliminateDe(rol);
                        MessageBox.Show("la funcionalidad ha sido eliminada", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else { MessageBox.Show("la funcionalidad " + funcionalidad.nombre +  " no existe para el rol " + rol.nombre + "", "Funcionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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

            if (create)
            {

                if (!this.existeNombre())
                {
                    Rol nuevoR = new Rol();
                    nuevoR.nombre = textBox_nombreRol.Text;
                    nuevoR.funcionalidades = func;
                    DAORol.crearRol(nuevoR);
                    MessageBox.Show("el rol ha sido creado exitosamente", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("el nombre del rol ya existe, por favor ingrese otro", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else {
                
                    rol.nombre = textBox_nombreRol.Text;
                    rol.funcionalidades = func;
                    this.rol = rol;
                    DAORol.actualizarRol(rol,this.nombreAnteriorRol,this.funcAnt);
                    this.Close();
                }
                
            }

        private bool existeNombre() {

            return DAORol.existeNombreRol(textBox_nombreRol.Text);
        }
        

        private void dataGridFuncionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
