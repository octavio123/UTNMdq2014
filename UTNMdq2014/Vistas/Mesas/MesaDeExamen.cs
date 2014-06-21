using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Vistas.Mesas
{
    public partial class MesaDeExamen : Form
    {
        public Mesa DatosMesa { get; set; }

        public MesaDeExamen(Mesa datosMesa)
        {
            InitializeComponent();

            DatosMesa = datosMesa;

            // Solo de prueba
            if (DatosMesa == null)
            {
                DatosMesa = new Mesa(
                    "M00031",
                    "WTF?",
                    040103,
                    new Materia("Fisica I", 2011, 43),
                    new Alumno[]
                    {
                        new Alumno("Pedro Jordan", "4331-2413", "pedro@yahoo.com", new DateTime(1980, 12, 12), new DateTime(2011, 12, 03))
                    }.ToList(),
                    new DateTime(2011, 08, 12)
                );

                DatosMesa.SetPresidente(new Profesor("Presidente Test", "325242", "a@a.com", DateTime.Now, DateTime.Now));
                DatosMesa.SetSecretario(new Profesor("Secretario Test", "2352342", "a@a.com", DateTime.Now, DateTime.Now));
                DatosMesa.SetVocales(new Profesor[] 
                                     {
                                        new Profesor("Vocal1", "1231241", "a@a.com", DateTime.Now, DateTime.Now),
                                        new Profesor("Vocal2", "41312314", "a@a.com", DateTime.Now, DateTime.Now)
                                     });
            }

            tbTomo.DataBindings.Add(new Binding("Text", DatosMesa, "Tomo"));
            tbFolio.DataBindings.Add(new Binding("Text", DatosMesa, "Folio"));
            tbCodigo.DataBindings.Add(new Binding("Text", DatosMesa, "Codigo"));
            tbPresidente.DataBindings.Add(new Binding("Text", DatosMesa, "Presidente"));
            tbVocal1.DataBindings.Add(new Binding("Text", DatosMesa, "Vocal1"));
            tbVocal2.DataBindings.Add(new Binding("Text", DatosMesa, "Vocal2"));

            dgvAlumnos.DataSource = DatosMesa.Alumnos;

            rtbObservaciones.DataBindings.Add(new Binding("Text", DatosMesa, "Observaciones"));

            tbInscriptos.DataBindings.Add(new Binding("Text", DatosMesa, "Inscriptos"));
            tbAprobados.DataBindings.Add(new Binding("Text", DatosMesa, "Aprobados"));
            tbDesaprobados.DataBindings.Add(new Binding("Text", DatosMesa, "Desaprobados"));
            tbExaminados.DataBindings.Add(new Binding("Text", DatosMesa, "Examinados"));
            tbAusentes.DataBindings.Add(new Binding("Text", DatosMesa, "Ausentes"));
            tbSecretario.DataBindings.Add(new Binding("Text", DatosMesa, "Secretario"));
            tbDecano.DataBindings.Add(new Binding("Text", DatosMesa, "Decano"));

            lblFecha.DataBindings.Add(new Binding("Text", DatosMesa, "Fecha"));


        }
    }
}
