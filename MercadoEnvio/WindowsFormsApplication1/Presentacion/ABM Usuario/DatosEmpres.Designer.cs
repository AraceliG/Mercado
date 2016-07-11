namespace MercadoEnvioFRBA.Presentacion.ABM_Usuario
{
    partial class DatosEmpres
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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_razon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "CUIT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "Razón Social:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 124;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_cuit
            // 
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(150, 385);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(152, 18);
            this.label_cuit.TabIndex = 125;
            this.label_cuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_razon
            // 
            this.label_razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razon.Location = new System.Drawing.Point(150, 414);
            this.label_razon.Name = "label_razon";
            this.label_razon.Size = new System.Drawing.Size(152, 18);
            this.label_razon.TabIndex = 126;
            this.label_razon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatosEmpres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 483);
            this.Controls.Add(this.label_razon);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "DatosEmpres";
            this.Text = "DatosEmpres";
            this.Load += new System.EventHandler(this.DatosEmpres_Load);
            this.Controls.SetChildIndex(this.label_reputacion, 0);
            this.Controls.SetChildIndex(this.label_postal, 0);
            this.Controls.SetChildIndex(this.label_depto, 0);
            this.Controls.SetChildIndex(this.label_piso, 0);
            this.Controls.SetChildIndex(this.label_nro, 0);
            this.Controls.SetChildIndex(this.label_calle, 0);
            this.Controls.SetChildIndex(this.label_tel, 0);
            this.Controls.SetChildIndex(this.label_mail, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label_nomUser, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label_cuit, 0);
            this.Controls.SetChildIndex(this.label_razon, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.Label label_razon;
    }
}