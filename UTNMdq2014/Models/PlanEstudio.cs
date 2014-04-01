using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
{
    public class PlanEstudio
    {
        public int PlanEstudioId { get; set; }
        public virtual ICollection<Materia> Materias { get; set; }
        public int Año { get; set; }

        public PlanEstudio(List<Materia> listaMaterias)
        {
            Materias = listaMaterias;
        }

        public PlanEstudio() : this(new List<Materia>())
        {
        }

        

        public void AgregarMateria(Materia materia)
        {
            if (materia == null)
            {
                string message = "La materia no puede ser nula.";
                throw new ArgumentNullException("materia", message);
            }
            
            Materias.Add(materia);
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            foreach (var mat in Materias)
            {
                message.AppendLine(mat.ToString());
            }

            return "Plan estudio " + "Año:" + Año + " Composicion:[ " + message.ToString() + " ]";
        }
    }
}
