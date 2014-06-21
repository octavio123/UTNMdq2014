using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Vistas.Alumnos
{
    public partial class AlumnoAgregar : Form
    {
        public Alumno Resultado { get; set; }
        
        public AlumnoAgregar(Alumno editar = null)
        {
            InitializeComponent();
            Resultado = (editar != null) ? editar : new Alumno();

            txtEmail.DataBindings.Add("Text", Resultado, "Email");
            txtNombre.DataBindings.Add("Text", Resultado, "Nombre");
            txtTelefono.DataBindings.Add("Text", Resultado, "Telefono");

            dtpFechaInicio.DataBindings.Add("Value", Resultado, "Ingreso");
            dtpFechaNac.DataBindings.Add("Value", Resultado, "Nacimiento");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            /*DateTime inicio, nacimiento;
            inicio = dtpFechaInicio.Value;
            nacimiento = dtpFechaNac.Value;*/

            // Toda esta cagada ^ y lo de abajo es por usar "Fecha" :P
            /*Resultado.Nacimiento = new Fecha(inicio.Day, inicio.Month, inicio.Year);
            Resultado.Ingreso = new Fecha(nacimiento.Day, nacimiento.Month, nacimiento.Year);*/
            Close();
        }




    }
}
