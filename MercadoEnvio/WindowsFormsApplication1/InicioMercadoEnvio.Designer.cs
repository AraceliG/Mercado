namespace MercadoEnvioFRBA
{
    partial class FormularioInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bienvenidaUsuario = new System.Windows.Forms.Label();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bienvenidaUsuario
            // 
            this.bienvenidaUsuario.AutoSize = true;
            this.bienvenidaUsuario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenidaUsuario.Location = new System.Drawing.Point(54, 37);
            this.bienvenidaUsuario.Name = "bienvenidaUsuario";
            this.bienvenidaUsuario.Size = new System.Drawing.Size(601, 44);
            this.bienvenidaUsuario.TabIndex = 0;
            this.bienvenidaUsuario.Text = "Bienvenido a Mercado Envio FRBA";
            this.bienvenidaUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Location = new System.Drawing.Point(266, 124);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(133, 23);
            this.IniciarSesion.TabIndex = 1;
            this.IniciarSesion.Text = "Iniciar sesión";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 198);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.bienvenidaUsuario);
            this.Name = "FormularioInicio";
            this.Text = "Inicio ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenidaUsuario;
        private System.Windows.Forms.Button IniciarSesion;
    }
}

