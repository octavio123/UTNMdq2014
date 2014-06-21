namespace UTNMdq2014.Vistas
{
    partial class Principal
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAlumnoEliminar = new System.Windows.Forms.Button();
            this.btnAlumnoEditar = new System.Windows.Forms.Button();
            this.btnAlumnoAgregar = new System.Windows.Forms.Button();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnProfesorEliminar = new System.Windows.Forms.Button();
            this.btnProfesorEditar = new System.Windows.Forms.Button();
            this.btnProfesorAgregar = new System.Windows.Forms.Button();
            this.lbProfesores = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMateriaEliminar = new System.Windows.Forms.Button();
            this.btnMateriaEditar = new System.Windows.Forms.Button();
            this.btnMateriaAgregar = new System.Windows.Forms.Button();
            this.lbMaterias = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkMesasExamen = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Location = new System.Drawing.Point(13, 33);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(515, 375);
            this.tab.TabIndex = 3;
            this.tab.Tag = "";
            this.tab.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnAlumnoEliminar);
            this.tabPage1.Controls.Add(this.btnAlumnoEditar);
            this.tabPage1.Controls.Add(this.btnAlumnoAgregar);
            this.tabPage1.Controls.Add(this.lbAlumnos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUMNOS";
            // 
            // btnAlumnoEliminar
            // 
            this.btnAlumnoEliminar.Location = new System.Drawing.Point(359, 130);
            this.btnAlumnoEliminar.Name = "btnAlumnoEliminar";
            this.btnAlumnoEliminar.Size = new System.Drawing.Size(140, 39);
            this.btnAlumnoEliminar.TabIndex = 11;
            this.btnAlumnoEliminar.Text = "Eliminar";
            this.btnAlumnoEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAlumnoEditar
            // 
            this.btnAlumnoEditar.Location = new System.Drawing.Point(359, 77);
            this.btnAlumnoEditar.Name = "btnAlumnoEditar";
            this.btnAlumnoEditar.Size = new System.Drawing.Size(140, 39);
            this.btnAlumnoEditar.TabIndex = 10;
            this.btnAlumnoEditar.Text = "Editar";
            this.btnAlumnoEditar.UseVisualStyleBackColor = true;
            // 
            // btnAlumnoAgregar
            // 
            this.btnAlumnoAgregar.Location = new System.Drawing.Point(359, 24);
            this.btnAlumnoAgregar.Name = "btnAlumnoAgregar";
            this.btnAlumnoAgregar.Size = new System.Drawing.Size(140, 39);
            this.btnAlumnoAgregar.TabIndex = 9;
            this.btnAlumnoAgregar.Text = "Agregar";
            this.btnAlumnoAgregar.UseVisualStyleBackColor = true;
            this.btnAlumnoAgregar.Click += new System.EventHandler(this.btnAlumnoAgregar_Click);
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Location = new System.Drawing.Point(8, 23);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(345, 303);
            this.lbAlumnos.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnProfesorEliminar);
            this.tabPage2.Controls.Add(this.btnProfesorEditar);
            this.tabPage2.Controls.Add(this.btnProfesorAgregar);
            this.tabPage2.Controls.Add(this.lbProfesores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROFESORES";
            // 
            // btnProfesorEliminar
            // 
            this.btnProfesorEliminar.Location = new System.Drawing.Point(359, 130);
            this.btnProfesorEliminar.Name = "btnProfesorEliminar";
            this.btnProfesorEliminar.Size = new System.Drawing.Size(140, 39);
            this.btnProfesorEliminar.TabIndex = 7;
            this.btnProfesorEliminar.Text = "Eliminar";
            this.btnProfesorEliminar.UseVisualStyleBackColor = true;
            // 
            // btnProfesorEditar
            // 
            this.btnProfesorEditar.Location = new System.Drawing.Point(359, 77);
            this.btnProfesorEditar.Name = "btnProfesorEditar";
            this.btnProfesorEditar.Size = new System.Drawing.Size(140, 39);
            this.btnProfesorEditar.TabIndex = 6;
            this.btnProfesorEditar.Text = "Editar";
            this.btnProfesorEditar.UseVisualStyleBackColor = true;
            // 
            // btnProfesorAgregar
            // 
            this.btnProfesorAgregar.Location = new System.Drawing.Point(359, 24);
            this.btnProfesorAgregar.Name = "btnProfesorAgregar";
            this.btnProfesorAgregar.Size = new System.Drawing.Size(140, 39);
            this.btnProfesorAgregar.TabIndex = 5;
            this.btnProfesorAgregar.Text = "Agregar";
            this.btnProfesorAgregar.UseVisualStyleBackColor = true;
            this.btnProfesorAgregar.Click += new System.EventHandler(this.btnProfesorAgregar_Click);
            // 
            // lbProfesores
            // 
            this.lbProfesores.FormattingEnabled = true;
            this.lbProfesores.Location = new System.Drawing.Point(8, 23);
            this.lbProfesores.Name = "lbProfesores";
            this.lbProfesores.Size = new System.Drawing.Size(345, 303);
            this.lbProfesores.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.btnMateriaEliminar);
            this.tabPage3.Controls.Add(this.btnMateriaEditar);
            this.tabPage3.Controls.Add(this.btnMateriaAgregar);
            this.tabPage3.Controls.Add(this.lbMaterias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(507, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MATERIAS";
            // 
            // btnMateriaEliminar
            // 
            this.btnMateriaEliminar.Location = new System.Drawing.Point(359, 130);
            this.btnMateriaEliminar.Name = "btnMateriaEliminar";
            this.btnMateriaEliminar.Size = new System.Drawing.Size(140, 39);
            this.btnMateriaEliminar.TabIndex = 11;
            this.btnMateriaEliminar.Text = "Eliminar";
            this.btnMateriaEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMateriaEditar
            // 
            this.btnMateriaEditar.Location = new System.Drawing.Point(359, 77);
            this.btnMateriaEditar.Name = "btnMateriaEditar";
            this.btnMateriaEditar.Size = new System.Drawing.Size(140, 39);
            this.btnMateriaEditar.TabIndex = 10;
            this.btnMateriaEditar.Text = "Editar";
            this.btnMateriaEditar.UseVisualStyleBackColor = true;
            // 
            // btnMateriaAgregar
            // 
            this.btnMateriaAgregar.Location = new System.Drawing.Point(359, 24);
            this.btnMateriaAgregar.Name = "btnMateriaAgregar";
            this.btnMateriaAgregar.Size = new System.Drawing.Size(140, 39);
            this.btnMateriaAgregar.TabIndex = 9;
            this.btnMateriaAgregar.Text = "Agregar";
            this.btnMateriaAgregar.UseVisualStyleBackColor = true;
            this.btnMateriaAgregar.Click += new System.EventHandler(this.btnMateriaAgregar_Click);
            // 
            // lbMaterias
            // 
            this.lbMaterias.FormattingEnabled = true;
            this.lbMaterias.Location = new System.Drawing.Point(8, 23);
            this.lbMaterias.Name = "lbMaterias";
            this.lbMaterias.Size = new System.Drawing.Size(345, 303);
            this.lbMaterias.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(507, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkMesasExamen
            // 
            this.linkMesasExamen.AutoSize = true;
            this.linkMesasExamen.Location = new System.Drawing.Point(534, 70);
            this.linkMesasExamen.Name = "linkMesasExamen";
            this.linkMesasExamen.Size = new System.Drawing.Size(93, 13);
            this.linkMesasExamen.TabIndex = 4;
            this.linkMesasExamen.TabStop = true;
            this.linkMesasExamen.Text = "Mesas de examen";
            this.linkMesasExamen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMesasExamen_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 420);
            this.Controls.Add(this.linkMesasExamen);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAlumnoEliminar;
        private System.Windows.Forms.Button btnAlumnoEditar;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.Button btnProfesorEliminar;
        private System.Windows.Forms.Button btnProfesorEditar;
        private System.Windows.Forms.Button btnProfesorAgregar;
        private System.Windows.Forms.ListBox lbProfesores;
        private System.Windows.Forms.Button btnMateriaEliminar;
        private System.Windows.Forms.Button btnMateriaEditar;
        private System.Windows.Forms.Button btnMateriaAgregar;
        private System.Windows.Forms.ListBox lbMaterias;
        private System.Windows.Forms.Button btnAlumnoAgregar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.LinkLabel linkMesasExamen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
    }
}