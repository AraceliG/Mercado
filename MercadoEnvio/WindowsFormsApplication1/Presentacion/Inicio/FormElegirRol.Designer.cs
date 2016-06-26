namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    partial class FormElegirRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el rol con el cual desea iniciar sesion:";
            // 
            // roles
            // 
            this.roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(84, 57);
            this.roles.Name = "roles";
            this.roles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roles.Size = new System.Drawing.Size(233, 26);
            this.roles.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormElegirRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.label1);
            this.Name = "FormElegirRol";
            this.Text = "Elegir Rol";
            this.Load += new System.EventHandler(this.FormElegirRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roles;
        private System.Windows.Forms.Button button1;
    }
}