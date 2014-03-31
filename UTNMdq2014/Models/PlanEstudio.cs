using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
{
    public class PlanEstudio
    {
        public List<Materia> Materias { get; set; }

        public PlanEstudio(List<Materia> listaMaterias)
        {
            Materias = listaMaterias;
        }

        public PlanEstudio() : this(new List<Materia>())
        {
        }

        public int PlanEstudioId { get; set; }

        public void AgregarMateria(Materia materia)
        {
            if (materia == null)
            {
                string message = "La materia no puede ser nula.";
                throw new ArgumentNullException("materia", message);
            }
            
            Materias.Add(materia);
        }
    }
}
