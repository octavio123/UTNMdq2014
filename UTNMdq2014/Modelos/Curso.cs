using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Curso
    {
        public List<Horario> Horarios { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Aula Aula { get; set; }

        public Curso() {}

        public Curso(Aula aula, List<Profesor> profesores, List<Alumno> alumnos)
        {
            Aula = aula;
        }
    }
}
