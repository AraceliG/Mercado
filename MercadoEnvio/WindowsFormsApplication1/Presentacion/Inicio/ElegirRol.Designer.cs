namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    partial class ElegirRol
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
            this.labelElegirRol = new System.Windows.Forms.Label();
            this.comboBoxElegirRol = new System.Windows.Forms.ComboBox();
            this.buttonElegirRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelElegirRol
            // 
            this.labelElegirRol.AutoSize = true;
            this.labelElegirRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElegirRol.Location = new System.Drawing.Point(31, 38);
            this.labelElegirRol.Name = "labelElegirRol";
            this.labelElegirRol.Size = new System.Drawing.Size(139, 31);
            this.labelElegirRol.TabIndex = 0;
            this.labelElegirRol.Text = "Elegir Rol:";
            // 
            // comboBoxElegirRol
            // 
            this.comboBoxElegirRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElegirRol.FormattingEnabled = true;
            this.comboBoxElegirRol.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.comboBoxElegirRol.Location = new System.Drawing.Point(196, 48);
            this.comboBoxElegirRol.Name = "comboBoxElegirRol";
            this.comboBoxElegirRol.Size = new System.Drawing.Size(186, 21);
            this.comboBoxElegirRol.TabIndex = 1;
            this.comboBoxElegirRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonElegirRol
            // 
            this.buttonElegirRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElegirRol.Location = new System.Drawing.Point(125, 110);
            this.buttonElegirRol.Name = "buttonElegirRol";
            this.buttonElegirRol.Size = new System.Drawing.Size(168, 65);
            this.buttonElegirRol.TabIndex = 2;
            this.buttonElegirRol.Text = "Elegir";
            this.buttonElegirRol.UseVisualStyleBackColor = true;
            this.buttonElegirRol.Click += new System.EventHandler(this.buttonElegirRol_Click);
            // 
            // ElegirRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 228);
            this.Controls.Add(this.buttonElegirRol);
            this.Controls.Add(this.comboBoxElegirRol);
            this.Controls.Add(this.labelElegirRol);
            this.Name = "ElegirRol";
            this.Text = "Elegir Rol";
            this.Load += new System.EventHandler(this.ElegirRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElegirRol;
        private System.Windows.Forms.ComboBox comboBoxElegirRol;
        private System.Windows.Forms.Button buttonElegirRol;
    }
}