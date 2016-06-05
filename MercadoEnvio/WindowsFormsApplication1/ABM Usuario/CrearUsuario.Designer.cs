namespace MercadoEnvioFRBA.ABM_Usuario
{
    partial class CrearUsuario
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
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_nroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 52;
            this.label12.Text = "Nro de Documento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nroDoc
            // 
            this.textBox_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nroDoc.Location = new System.Drawing.Point(170, 19);
            this.textBox_nroDoc.Name = "textBox_nroDoc";
            this.textBox_nroDoc.Size = new System.Drawing.Size(165, 24);
            this.textBox_nroDoc.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tipo de Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_tipoDoc
            // 
            this.comboBox_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipoDoc.FormattingEnabled = true;
            this.comboBox_tipoDoc.Location = new System.Drawing.Point(170, 49);
            this.comboBox_tipoDoc.Name = "comboBox_tipoDoc";
            this.comboBox_tipoDoc.Size = new System.Drawing.Size(165, 26);
            this.comboBox_tipoDoc.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(170, 80);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(165, 24);
            this.textBox_nombre.TabIndex = 57;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 350);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_tipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nroDoc);
            this.Controls.Add(this.label12);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_nroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nombre;
    }
}