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

            using (FacultadDbContext dbContext = new FacultadDbContext())
            {

                textBox.Text += "Alumnos:\n" +
                                dbContext.Alumnos.ToList()[0] + "\n" +
                                "Profesores:\n" +
                                dbContext.Profesores.ToList()[0] + "\n" +
                                "Legajos:\n" +
                                dbContext.Legajos.ToList()[0] + "\n";

                textBox.Text += "\nMaterias:\n" /*+ dbContext.Materias.ToList()[0] */+ dbContext.Materias.ToList()[1];
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
