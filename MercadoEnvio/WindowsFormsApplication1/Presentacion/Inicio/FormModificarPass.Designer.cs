namespace MercadoEnvioFRBA.Presentacion.Inicio
{
    partial class FormModificarPass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_nuevoPass = new System.Windows.Forms.TextBox();
            this.txt_nuevoPass2 = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.error_pass_viejo = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_pass_nuevo1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_pass_nuevo2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_viejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_nuevo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_nuevo2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese su nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ingrese nueva contraseña nuevamente";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(302, 71);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(232, 26);
            this.txt_user.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(302, 118);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(232, 26);
            this.txt_pass.TabIndex = 6;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_nuevoPass
            // 
            this.txt_nuevoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevoPass.Location = new System.Drawing.Point(302, 158);
            this.txt_nuevoPass.Name = "txt_nuevoPass";
            this.txt_nuevoPass.Size = new System.Drawing.Size(232, 26);
            this.txt_nuevoPass.TabIndex = 7;
            this.txt_nuevoPass.UseSystemPasswordChar = true;
            // 
            // txt_nuevoPass2
            // 
            this.txt_nuevoPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevoPass2.Location = new System.Drawing.Point(302, 201);
            this.txt_nuevoPass2.Name = "txt_nuevoPass2";
            this.txt_nuevoPass2.Size = new System.Drawing.Size(232, 26);
            this.txt_nuevoPass2.TabIndex = 8;
            this.txt_nuevoPass2.UseSystemPasswordChar = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.Image")));
            this.btn_aceptar.Location = new System.Drawing.Point(313, 247);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(138, 44);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // error_pass_viejo
            // 
            this.error_pass_viejo.ContainerControl = this;
            // 
            // error_pass_nuevo1
            // 
            this.error_pass_nuevo1.ContainerControl = this;
            // 
            // error_pass_nuevo2
            // 
            this.error_pass_nuevo2.ContainerControl = this;
            // 
            // FormModificarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 316);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nuevoPass2);
            this.Controls.Add(this.txt_nuevoPass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModificarPass";
            this.Text = "Modificar contraseña";
            this.Load += new System.EventHandler(this.FormModificarPass_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_user, 0);
            this.Controls.SetChildIndex(this.txt_pass, 0);
            this.Controls.SetChildIndex(this.txt_nuevoPass, 0);
            this.Controls.SetChildIndex(this.txt_nuevoPass2, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_viejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_nuevo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass_nuevo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_nuevoPass;
        private System.Windows.Forms.TextBox txt_nuevoPass2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ErrorProvider error_pass_viejo;
        private System.Windows.Forms.ErrorProvider error_pass_nuevo1;
        private System.Windows.Forms.ErrorProvider error_pass_nuevo2;
    }
}