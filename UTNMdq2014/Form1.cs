using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Models;

namespace UTNMdq2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Materia matematica, estadistica;
            matematica = new Materia("Matematica", 1, 12);
            estadistica = new Materia("Estadistica", 2, 24, new Requisito(matematica, true, false));
            
            Materia[] materias = new Materia[] { matematica, estadistica };
            StringBuilder materiaInfo = new StringBuilder();

            foreach (Materia mat in materias)
            {
                materiaInfo.Append(mat + "\n");
            }

            textBox.Text = materiaInfo.ToString();

            FacultadDbContext dbContext = new FacultadDbContext();

            foreach(var alumno in dbContext.Alumnos)
            {
                textBox.Text += alumno + "\n";
            }

            dbContext.Dispose();
        }
    }
}
