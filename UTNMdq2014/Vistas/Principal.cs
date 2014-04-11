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
            ProfesorAgregar form = new ProfesorAgregar();
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

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            profesores.Dispose();
            alumnos.Dispose();
            materias.Dispose();

            Close();
            parent.Close();
        }
    }
}
