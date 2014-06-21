using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Legajo
    {
        public int LegajoId { get; set; } // Matricula

        public PlanEstudio Plan { get; set; }

        public List<Materia> Cursada { get; set; }
        public List<Materia> Aprobadas { get; set; }
        public List<Materia> Regulares { get; set; }

        public List<Examen> Examenes { get; set; }

        public Legajo() {}

        public override string ToString()
        {
            if (Plan != null)
                return Plan.ToString();
            return "";
        }
    }
}
