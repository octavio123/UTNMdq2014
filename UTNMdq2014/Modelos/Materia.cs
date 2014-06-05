using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Materia
    {

        static readonly int NotaMinima = 4;

        private string nombre;

        #region Propiedades

        public int MateriaId { get; protected set; }

        public PlanEstudio Plan { get; protected set; }

        public List<Examen> Examenes { get; protected set; }

        public Horario Horario { get; protected set; }

        /// <summary>
        /// Calcula el promedio que se obtubo en la materia.
        /// </summary>
        public static double ObtenerPromedio(List<Examen> examenes)
        {
            double sumNota = 0;
            foreach (var examen in examenes)
            {
                sumNota += examen.Nota;
            }

            return sumNota / examenes.Count;
        }

        /// <summary>
        /// Determina si la materia se encuentra aprobada.
        /// </summary>
        public bool Aprobada 
        { 
            get
            {
                return EstaAprobada(this);
            }
        }

        /// <summary>
        /// Determina si la materia se encuentra cursada.
        /// </summary>
        public bool Cursada
        {
            get
            {
                return EstaCursada(this);
            }
        }

        /// <summary>
        /// Retorna si la materia fue cursada correctamente.
        /// </summary>
        private static bool EstaCursada(Materia materia)
        {
            List<Examen> parciales = materia.Examenes.Where(x => x.Parcial).ToList();
            bool cursada = parciales.TrueForAll(x => x.Nota == NotaMinima);

            return cursada;
        }

        public string Nombre
        {
            get { return nombre; }
            protected set
            {
                if (Validador.EsNombreValido(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("nombre", "El valor especificado es inválido.");
                }
            }
        }

        public int Año
        {
            get;
            set;
        }

        public int CargaHoraria { get; protected set; }

        public int HorasCursadas { get; protected set; }
        
        #endregion

        /// <summary>
        /// Obtiene si la materia se encuentra aprobada.
        /// </summary>
        private static bool EstaAprobada(Materia materia)
        {
            List<Examen> parciales = materia.Examenes.Where(x => x.Parcial ).ToList();
            List<Examen> finales = materia.Examenes.Where(x => !x.Parcial ).ToList();

            int parcialesAprobados = parciales.Where(x => x.Nota >= NotaMinima).Count();
            int finalesAprobados = finales.Where(x => x.Nota >= NotaMinima).Count();

            return ( finalesAprobados == finales.Count &&
                    parcialesAprobados == parciales.Count );
        }

        public Materia()
        {
        }

        public Materia(string nombre, int año, int cargaHoraria)
        {
            Nombre = nombre;
            Año = año;
            CargaHoraria = cargaHoraria;

            Examenes = new List<Examen>();
        }

        /// <summary>
        /// Agrega un examen a la lista de examenes para la materia.
        /// </summary>
        /// <param name="examen">Un <see cref="Examen"/> correspondiente a la materia.</param>
        public void AgregarExamen(Examen examen)
        {
            if (examen == null) { throw new ArgumentNullException("examen", "No debe ser nulo."); }
            if (examen.MateriaCorrespondiente != this) { throw new ArgumentException("examen", "Debe pertenecer a esta materia."); }

            Examenes.Add(examen);
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
