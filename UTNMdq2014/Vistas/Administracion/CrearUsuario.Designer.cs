namespace UTNMdq2014.Vistas.Administracion
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
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConfirmacionContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(105, 122);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(100, 21);
            this.cbTipoUsuario.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(105, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(104, 45);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.ShortcutsEnabled = false;
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de cuenta";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(40, 160);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmacion\n";
            // 
            // tbConfirmacionContraseña
            // 
            this.tbConfirmacionContraseña.Location = new System.Drawing.Point(104, 83);
            this.tbConfirmacionContraseña.Name = "tbConfirmacionContraseña";
            this.tbConfirmacionContraseña.ShortcutsEnabled = false;
            this.tbConfirmacionContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbConfirmacionContraseña.TabIndex = 9;
            this.tbConfirmacionContraseña.UseSystemPasswordChar = true;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.tbConfirmacionContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbTipoUsuario);
            this.Name = "CrearUsuario";
            this.Text = "Datos usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConfirmacionContraseña;
    }
}