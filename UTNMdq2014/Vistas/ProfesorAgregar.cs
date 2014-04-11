using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Vistas
{
    public partial class ProfesorAgregar : Form
    {
        public Profesor Resultado { get; set; }
        
        public ProfesorAgregar(Profesor editar = null)
        {
            InitializeComponent();
            Resultado = (editar != null) ? editar : new Profesor();

            txtEmail.DataBindings.Add("Text", Resultado, "Email");
            txtNombre.DataBindings.Add("Text", Resultado, "Nombre");
            txtTelefono.DataBindings.Add("Text", Resultado, "Telefono");

            // El usar una estúpida clase Fecha y suponer que podes usarla con un calendario está mal. :\
            // dtpFechaInicio.DataBindings.Add("Value", Resultado, "Ingreso");
            Fecha inicio, nacimiento;
            inicio = Resultado.Ingreso;
            nacimiento = Resultado.Nacimiento;

            // Toda esta cagada ^ y lo de abajo es por usar "Fecha" :P
            try { dtpFechaNac.Value = new DateTime(inicio.Año, inicio.Mes, inicio.Dia, 13, 0, 0); }
            catch (ArgumentOutOfRangeException ex) { dtpFechaNac.Value = DateTime.Now; }

            try { dtpFechaInicio.Value = new DateTime(nacimiento.Año, nacimiento.Mes, nacimiento.Dia); }
            catch (ArgumentOutOfRangeException ex) { dtpFechaInicio.Value = DateTime.Now; }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DateTime inicio, nacimiento;
            inicio = dtpFechaInicio.Value;
            nacimiento = dtpFechaNac.Value;

            // Toda esta cagada ^ y lo de abajo es por usar "Fecha" :P
            Resultado.Nacimiento = new Fecha(inicio.Day, inicio.Month, inicio.Year);
            Resultado.Ingreso = new Fecha(nacimiento.Day, nacimiento.Month, nacimiento.Year);
            Close();
        }




    }
}
