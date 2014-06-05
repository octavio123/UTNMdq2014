using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Examen
    {
        public int ExamenId { get; private set; }

        public int Nota { get; private set; }

        public bool Parcial { get; private set; }

        public Materia MateriaCorrespondiente { get; protected set; }

        public Examen()
        { 
        }

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
