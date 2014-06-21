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

        public Dictionary<Materia, List<Requisito> > Correlatividades { get; set; }

        public int Año { get; set; }

        public EstadoContable EstadoContable { get; set; }

        public PlanEstudio(List<Materia> listaMaterias)
        {
            materias = listaMaterias;
            Correlatividades = new Dictionary<Materia, List<Requisito>>();
        }

        public PlanEstudio()
        {
            materias = new List<Materia>();
            Correlatividades = new Dictionary<Materia, List<Requisito>>();
        }


        /// <summary>
        /// Retorna las materias correspondientes al plan de estudio.
        /// </summary>
        /// <returns>Una lista de materias.</returns>
        public List<Materia> ObtenerMaterias()
        {
            return new List<Materia>(materias);
        }

        /// <summary>
        /// Agrega la materia a la lista con los requisitos.
        /// </summary>
        /// <param name="materia">Una <see cref="Materia"/>.</param>
        /// <param name="requisitos">Una lista de <see cref="Requisito"/> para cursar o rendir la materia.</param>
        public void AgregarMateria(Materia materia, List<Requisito> requisitos = null)
        {
            if (materia == null)
            {
                string message = "La materia no puede ser nula.";
                throw new ArgumentNullException("materia", message);
            }

            materias.Add(materia);

            if (requisitos == null)
            {
                requisitos = new List<Requisito>();
            }

            Correlatividades.Add(materia, requisitos);
        }

        /// <summary>
        /// Agrega la materia a la lista con los requisitos.
        /// </summary>
        /// <param name="materia">Una <see cref="Materia"/>.</param>
        /// <param name="requisitos">Una lista de <see cref="Requisito"/> para cursar o rendir la materia.</param>
        public void AgregarMateria(Materia materia, Requisito requisito)
        {
            var requisitos = new List<Requisito>();
            requisitos.Add(requisito);
            AgregarMateria(materia, requisitos);
        }

        /// <summary>
        /// Agrega la materia a la lista.
        /// </summary>
        /// <param name="materia">Una <see cref="Materia"/>.</param>
        public void AgregarMateria(Materia materia)
        {
            AgregarMateria(materia, new List<Requisito>());
        }

        public bool EstaHabilitada(string nombreMateria)
        {
            Materia m = materias.Find((materia) => materia.Nombre == nombreMateria);

            if (m == null)
            {
                throw new ArgumentException("nombreMateria", "No existe una materia con ese nombre");
            }

            return EstaHabilitada(m);
        }

        /// <summary>
        /// Muestra si la materia se encuentra en condiciones de
        /// ser cursada en base al <see cref=Requisito>.</see>
        /// </summary>
        public bool EstaHabilitada(Materia materia)
        {
            if (materia == null)
            {
                throw new ArgumentNullException("materia", "No se puede comprobar una materia nula.");
            }

            return Correlatividades[materia].TrueForAll((r) => r.Cumplido);
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
