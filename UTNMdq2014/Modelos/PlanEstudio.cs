using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class PlanEstudio
    {
        public int PlanEstudioId { get; set; }
        
        private List<Materia> materias;
        private Dictionary<Materia, List<Requisito>> Correlatividades { get; set; }

        public int Año { get; set; }
        public EstadoContable EstadoContable { get; set; }

        public PlanEstudio(List<Materia> listaMaterias)
        {
            materias = listaMaterias;
        }

        public PlanEstudio() : this(new List<Materia>())
        {
        }


        public List<Materia> ObtenerMaterias()
        {
            return new List<Materia>(materias);
        }

        public void AgregarMateria(Materia materia)
        {
            if (materia == null)
            {
                string message = "La materia no puede ser nula.";
                throw new ArgumentNullException("materia", message);
            }
            
            materias.Add(materia);
        }

        /// <summary>
        /// Muestra si la materia se encuentra en condiciones de
        /// ser cursada en base al <see cref=Requisito></see>
        /// </summary>
        public bool PuedeCursarse(Materia materia)
        {
            bool cumplidos = Correlatividades[materia].TrueForAll(x => x.Cumplido);
            return cumplidos;
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            foreach (var mat in materias)
            {
                message.AppendLine(mat.ToString());
            }

            return "Plan estudio " + "Año:" + Año + " Composicion:[ " + message.ToString() + " ]";
        }
    }
}
