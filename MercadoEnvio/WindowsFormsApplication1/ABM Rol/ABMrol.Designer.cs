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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Roles";
            // 
            // dataGridViewRol
            // 
            this.dataGridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRol.Location = new System.Drawing.Point(53, 66);
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.Size = new System.Drawing.Size(573, 192);
            this.dataGridViewRol.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Rol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ABMrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewRol);
            this.Controls.Add(this.label1);
            this.Name = "ABMrol";
            this.Text = "Listado de Roles";
            this.Load += new System.EventHandler(this.ABMrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRol;
        private System.Windows.Forms.Button button1;
    }
}