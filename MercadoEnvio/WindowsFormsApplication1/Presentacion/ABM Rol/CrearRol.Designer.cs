namespace MercadoEnvioFRBA.Presentacion.ABM_Rol
{
    partial class CrearRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombreRol = new System.Windows.Forms.TextBox();
            this.dataGridFuncionalidad = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.errorProvider_nombreRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombreRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Rol:";
            // 
            // textBox_nombreRol
            // 
            this.textBox_nombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombreRol.Location = new System.Drawing.Point(165, 66);
            this.textBox_nombreRol.Name = "textBox_nombreRol";
            this.textBox_nombreRol.Size = new System.Drawing.Size(188, 26);
            this.textBox_nombreRol.TabIndex = 2;
            // 
            // dataGridFuncionalidad
            // 
            this.dataGridFuncionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionalidad.Location = new System.Drawing.Point(57, 154);
            this.dataGridFuncionalidad.Name = "dataGridFuncionalidad";
            this.dataGridFuncionalidad.Size = new System.Drawing.Size(580, 218);
            this.dataGridFuncionalidad.TabIndex = 3;
            this.dataGridFuncionalidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFuncionalidad_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(165, 404);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(135, 32);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(381, 404);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(127, 32);
            this.btn_quitar.TabIndex = 5;
            this.btn_quitar.Text = "quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // errorProvider_nombreRol
            // 
            this.errorProvider_nombreRol.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elija una funcionalidad:";
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dataGridFuncionalidad);
            this.Controls.Add(this.textBox_nombreRol);
            this.Controls.Add(this.label1);
            this.Name = "CrearRol";
            this.Text = "CrearRol";
            this.Load += new System.EventHandler(this.CrearRol_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_nombreRol, 0);
            this.Controls.SetChildIndex(this.dataGridFuncionalidad, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.btn_quitar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombreRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombreRol;
        private System.Windows.Forms.DataGridView dataGridFuncionalidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.ErrorProvider errorProvider_nombreRol;
        private System.Windows.Forms.Label label2;
    }
}