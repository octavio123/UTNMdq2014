using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Mesa
    {
        private Materia materia;

        public string Decano { set; get; }
        public string Presidente { set; get; }
        public string Secretario { get; set; }
        public string Vocal1 { set; get; }
        public string Vocal2 { set; get; }

        public string Tomo { set; get; }
        public string Folio { set; get; }
        public Materia Materia { set; get; }
        public string Observaciones { set; get; }


        public int Codigo { set; get; }
        public int Inscriptos { set; get; }
        public int Examinados { set; get; }
        public int Aprobados { set; get; }
        public int Ausentes { set; get; }
        public int Desaprobados { set; get; }

        public DateTime Fecha { set; get; }

        public BindingList<Alumno> Alumnos { get; set; }

        public Mesa()
        { 
        }

        public Mesa(string tomo, string folio, int codigo, Materia materia, List<Alumno> alumnos, DateTime fecha)
        {
            Tomo = tomo;
            Folio = folio;
            Codigo = codigo;
            Decano = Facultad.Decano;
            Alumnos = new BindingList<Alumno>(alumnos);
            Fecha = fecha;
            Materia = materia;
        }

        public void SetVocales(Profesor[] profesores)
        {
            if (profesores == null)
            {
                throw new ArgumentNullException("profesores");
            }
            if (profesores.Length < 2)
            {
                throw new ArgumentOutOfRangeException("profesores", "Se deben elegir dos profesores para los puestos de vocales.");
            }

            if (Vocal1 != "" && Vocal2 != "")
            {
                Vocal1 = profesores[0].Nombre;
                Vocal2 = profesores[1].Nombre;
            }
        }

        public void SetPresidente(Profesor presidente)
        {
            if (presidente == null)
            {
                throw new ArgumentNullException("presidente");
            }

            Presidente = presidente.Nombre;
        }
        public void SetSecretario(Profesor secretario)
        {
            if (secretario == null)
            {
                throw new ArgumentNullException("secretario");
            }

            Presidente = secretario.Nombre;
        }
    }
}
