namespace MercadoEnvioFRBA.ABM_Rol
{
    partial class ABMrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMrol));
            this.btn_CrearRol = new System.Windows.Forms.Button();
            this.btn_modificarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearRol
            // 
            this.btn_CrearRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearRol.Image = ((System.Drawing.Image)(resources.GetObject("btn_CrearRol.Image")));
            this.btn_CrearRol.Location = new System.Drawing.Point(31, 65);
            this.btn_CrearRol.Name = "btn_CrearRol";
            this.btn_CrearRol.Size = new System.Drawing.Size(185, 58);
            this.btn_CrearRol.TabIndex = 1;
            this.btn_CrearRol.Text = "Crear Rol";
            this.btn_CrearRol.UseVisualStyleBackColor = true;
            // 
            // btn_modificarRol
            // 
            this.btn_modificarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarRol.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarRol.Image")));
            this.btn_modificarRol.Location = new System.Drawing.Point(260, 65);
            this.btn_modificarRol.Name = "btn_modificarRol";
            this.btn_modificarRol.Size = new System.Drawing.Size(188, 58);
            this.btn_modificarRol.TabIndex = 2;
            this.btn_modificarRol.Text = "Modificar Rol";
            this.btn_modificarRol.UseVisualStyleBackColor = true;
            this.btn_modificarRol.Click += new System.EventHandler(this.btn_modificarRol_Click);
            // 
            // ABMrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 161);
            this.Controls.Add(this.btn_modificarRol);
            this.Controls.Add(this.btn_CrearRol);
            this.Name = "ABMrol";
            this.Text = "AbmRol";
            this.Load += new System.EventHandler(this.ABMrol_Load);
            this.Controls.SetChildIndex(this.btn_CrearRol, 0);
            this.Controls.SetChildIndex(this.btn_modificarRol, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearRol;
        private System.Windows.Forms.Button btn_modificarRol;

    }
}