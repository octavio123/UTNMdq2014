using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Datos;

namespace UTNMdq2014.Vistas
{
    public partial class Principal : Form
    {
        ProfesoresRepositorio profesores;
        AlumnosRepositorio alumnos;
        MateriasRepositorio materias;

        private Form parent;

        public Principal(Form parent = null)
        {
            InitializeComponent();

            this.parent = parent;

            profesores = new ProfesoresRepositorio();
            alumnos = new AlumnosRepositorio();
            materias = new MateriasRepositorio();

            lbProfesores.DataSource = profesores.Profesores;

            lbAlumnos.DataSource = alumnos.Alumnos;
            lbMaterias.DataSource = materias.Materias;

            lbAlumnos.Update();
            lbProfesores.Update();
            lbMaterias.Update();
        }


        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnProfesorAgregar_Click(object sender, EventArgs e)
        {
            Profesores.ProfesorAgregar form = new Profesores.ProfesorAgregar();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                profesores.Profesores.Add(form.Resultado);
            }
        }

        private void btnMateriaAgregar_Click(object sender, EventArgs e)
        {
        }

        private void btnAlumnoAgregar_Click(object sender, EventArgs e)
        {
            Alumnos.AlumnoAgregar form = new Alumnos.AlumnoAgregar();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                alumnos.Alumnos.Add(form.Resultado);
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            profesores.Dispose();
            alumnos.Dispose();
            materias.Dispose();

            if (parent != null)
            {
                parent.Close();
            }
        }

        private void linkMesasExamen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mesas.MesaDeExamen form = new Mesas.MesaDeExamen(null); // Prueba
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        /// <summary>
        /// Llama a la vista para creación y modificacion de cuentas de acceso al sistema.
        /// </summary>
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administracion.Usuarios form = new Administracion.Usuarios();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
