namespace MercadoEnvioFRBA.Presentacion.ABM_Rol
{
    partial class BuscarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRol));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRol = new System.Windows.Forms.DataGridView();
            this.btn_modificarRol = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROLES:";
            // 
            // dataGridRol
            // 
            this.dataGridRol.AllowUserToOrderColumns = true;
            this.dataGridRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRol.Location = new System.Drawing.Point(40, 62);
            this.dataGridRol.Name = "dataGridRol";
            this.dataGridRol.Size = new System.Drawing.Size(593, 173);
            this.dataGridRol.TabIndex = 3;
            // 
            // btn_modificarRol
            // 
            this.btn_modificarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarRol.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarRol.Image")));
            this.btn_modificarRol.Location = new System.Drawing.Point(40, 241);
            this.btn_modificarRol.Name = "btn_modificarRol";
            this.btn_modificarRol.Size = new System.Drawing.Size(93, 42);
            this.btn_modificarRol.TabIndex = 4;
            this.btn_modificarRol.Text = "MODIFICAR";
            this.btn_modificarRol.UseVisualStyleBackColor = true;
            this.btn_modificarRol.Click += new System.EventHandler(this.btn_modificarRol_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta.Image = ((System.Drawing.Image)(resources.GetObject("btn_alta.Image")));
            this.btn_alta.Location = new System.Drawing.Point(292, 241);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(93, 42);
            this.btn_alta.TabIndex = 5;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baja.Image = ((System.Drawing.Image)(resources.GetObject("btn_baja.Image")));
            this.btn_baja.Location = new System.Drawing.Point(540, 241);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(93, 42);
            this.btn_baja.TabIndex = 6;
            this.btn_baja.Text = "BAJA";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // BuscarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 312);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.btn_modificarRol);
            this.Controls.Add(this.dataGridRol);
            this.Controls.Add(this.label1);
            this.Name = "BuscarRol";
            this.Text = "Buscar  Rol";
            this.Load += new System.EventHandler(this.BuscarRol_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGridRol, 0);
            this.Controls.SetChildIndex(this.btn_modificarRol, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_baja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRol;
        private System.Windows.Forms.Button btn_modificarRol;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
    }
}