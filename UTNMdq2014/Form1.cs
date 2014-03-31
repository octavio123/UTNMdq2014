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

            FacultadDbContext dbContext = new FacultadDbContext();
            textBox.Text += dbContext.Alumnos.ToList()[0] + "\n" +
                            dbContext.Materias.ToList()[0] + "\n" +
                            dbContext.Profesores.ToList()[0] + "\n" +
                            dbContext.Legajos.ToList()[0] + "\n";

            dbContext.Dispose();
        }
    }
}
