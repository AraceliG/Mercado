﻿namespace MercadoEnvioFRBA.Presentacion.Listado_Estadistico
{
    partial class ClieMayorCantFacturasPorRubro
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
            this.gbElegir = new System.Windows.Forms.GroupBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.gbElegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElegir
            // 
            this.gbElegir.Controls.Add(this.lblSemestre);
            this.gbElegir.Controls.Add(this.lblAnio);
            this.gbElegir.Controls.Add(this.lblListado);
            this.gbElegir.Controls.Add(this.cmbTrimestre);
            this.gbElegir.Controls.Add(this.cmbAnio);
            this.gbElegir.Controls.Add(this.cmbRubro);
            this.gbElegir.Controls.Add(this.btnListar);
            this.gbElegir.Location = new System.Drawing.Point(37, 29);
            this.gbElegir.Name = "gbElegir";
            this.gbElegir.Size = new System.Drawing.Size(790, 66);
            this.gbElegir.TabIndex = 3;
            this.gbElegir.TabStop = false;
            this.gbElegir.Text = "Elegir";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(10, 29);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(53, 13);
            this.lblSemestre.TabIndex = 6;
            this.lblSemestre.Text = "Trimestre:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(196, 31);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "Año:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(322, 29);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(39, 13);
            this.lblListado.TabIndex = 4;
            this.lblListado.Text = "Rubro:";
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(69, 26);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(105, 21);
            this.cmbTrimestre.TabIndex = 3;
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(231, 26);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(79, 21);
            this.cmbAnio.TabIndex = 2;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(384, 26);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(281, 21);
            this.cmbRubro.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(684, 24);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(73, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(119, 101);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(645, 282);
            this.dgvListado.TabIndex = 4;
            // 
            // ClieMayorCantFacturasPorRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 420);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.gbElegir);
            this.Name = "ClieMayorCantFacturasPorRubro";
            this.Text = "ClieMayorCantFacturasPorRubro";
            this.Load += new System.EventHandler(this.ClieMayorCantFacturasPorRubro_Load);
            this.gbElegir.ResumeLayout(false);
            this.gbElegir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElegir;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}