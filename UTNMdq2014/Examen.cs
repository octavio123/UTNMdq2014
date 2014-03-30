using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Examen
    {
        public int Nota { get; protected set; }

        public bool Parcial { get; protected set; }

        public Materia MateriaCorrespondiente { get; protected set; }

        public Examen (Materia materia, int nota, bool parcial)
        {
            if (nota <= 0 || nota > 10)
                throw new ArgumentOutOfRangeException("nota", "La nota debe estar entre 1 y 10.");
            if (materia == null)
                throw new ArgumentNullException("materia", "Un examen debe pertenecer a una materia.");

            Nota = nota;
            Parcial = parcial;
            MateriaCorrespondiente = materia;
        }
    }
}
