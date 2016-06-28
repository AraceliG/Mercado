namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    partial class FormABMUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMUsuario));
            this.btn_crearEmp = new System.Windows.Forms.Button();
            this.btn_crearCliente = new System.Windows.Forms.Button();
            this.btn_busquedaEmp = new System.Windows.Forms.Button();
            this.btn_BusquedaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crearEmp
            // 
            this.btn_crearEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_crearEmp.BackgroundImage")));
            this.btn_crearEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearEmp.Location = new System.Drawing.Point(30, 81);
            this.btn_crearEmp.Name = "btn_crearEmp";
            this.btn_crearEmp.Size = new System.Drawing.Size(175, 41);
            this.btn_crearEmp.TabIndex = 1;
            this.btn_crearEmp.Text = "Crear Empresa";
            this.btn_crearEmp.UseVisualStyleBackColor = true;
            this.btn_crearEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_crearCliente
            // 
            this.btn_crearCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_crearCliente.BackgroundImage")));
            this.btn_crearCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearCliente.Location = new System.Drawing.Point(246, 81);
            this.btn_crearCliente.Name = "btn_crearCliente";
            this.btn_crearCliente.Size = new System.Drawing.Size(166, 41);
            this.btn_crearCliente.TabIndex = 2;
            this.btn_crearCliente.Text = "Crear Cliente";
            this.btn_crearCliente.UseVisualStyleBackColor = true;
            // 
            // btn_busquedaEmp
            // 
            this.btn_busquedaEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busquedaEmp.BackgroundImage")));
            this.btn_busquedaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busquedaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaEmp.Location = new System.Drawing.Point(30, 143);
            this.btn_busquedaEmp.Name = "btn_busquedaEmp";
            this.btn_busquedaEmp.Size = new System.Drawing.Size(175, 41);
            this.btn_busquedaEmp.TabIndex = 3;
            this.btn_busquedaEmp.Text = "Buscar Empresa";
            this.btn_busquedaEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busquedaEmp.UseVisualStyleBackColor = true;
            // 
            // btn_BusquedaCliente
            // 
            this.btn_BusquedaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BusquedaCliente.BackgroundImage")));
            this.btn_BusquedaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BusquedaCliente.Location = new System.Drawing.Point(246, 143);
            this.btn_BusquedaCliente.Name = "btn_BusquedaCliente";
            this.btn_BusquedaCliente.Size = new System.Drawing.Size(166, 41);
            this.btn_BusquedaCliente.TabIndex = 4;
            this.btn_BusquedaCliente.Text = "Buscar Cliente";
            this.btn_BusquedaCliente.UseVisualStyleBackColor = true;
            // 
            // FormABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 225);
            this.Controls.Add(this.btn_BusquedaCliente);
            this.Controls.Add(this.btn_busquedaEmp);
            this.Controls.Add(this.btn_crearCliente);
            this.Controls.Add(this.btn_crearEmp);
            this.Name = "FormABMUsuario";
            this.Text = "FormABMUsuario";
            this.Load += new System.EventHandler(this.FormABMUsuario_Load);
            this.Controls.SetChildIndex(this.btn_crearEmp, 0);
            this.Controls.SetChildIndex(this.btn_crearCliente, 0);
            this.Controls.SetChildIndex(this.btn_busquedaEmp, 0);
            this.Controls.SetChildIndex(this.btn_BusquedaCliente, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearEmp;
        private System.Windows.Forms.Button btn_crearCliente;
        private System.Windows.Forms.Button btn_busquedaEmp;
        private System.Windows.Forms.Button btn_BusquedaCliente;
    }
}