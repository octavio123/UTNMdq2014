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

        string nombre;

        #region Propiedades

        public int MateriaId { get; set; }
        public PlanEstudio Plan { get; set; }
        public List<Examen> Examenes { get; set; }
        public Horario Horario { get; set; }



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
            set
            {
                if (ValidadorPersona.EsNombreValido(value))
                    nombre = value;
                else
                    throw new ArgumentException("nombre", "El valor especificado es inválido.");
            }
        }

        public int Año
        {
            get;
            set;
        }

        public int CargaHoraria { get; set; }

        public int HorasCursadas { get; set; }
        
        #endregion

        private static bool EstaAprobada(Materia materia)
        {
            List<Examen> parciales = materia.Examenes.Where(x => (x.Parcial)).ToList();
            List<Examen> finales = materia.Examenes.Where(x => (!x.Parcial)).ToList();

            int parcialesAprobados = parciales.Where(x => x.Nota >= NotaMinima).Count();
            int finalesAprobados = finales.Where(x => x.Nota >= NotaMinima).Count();

            return (finalesAprobados == finales.Count) &&
                   (parcialesAprobados == parciales.Count);
        }

        public Materia() : this("Indefinido", 0, 0)
        {
        }

        public Materia(string nombre, int año, int cargaHoraria, List<Requisito> requisitos = null)
        {
            Nombre = nombre;
            Año = año;
            Requisitos = requisitos;
            CargaHoraria = cargaHoraria;

            Examenes = new List<Examen>();
            if (requisitos == null)
                Requisitos = new List<Requisito>();
            else
                Requisitos = requisitos;
        }

        public Materia (string nombre, int año, int cargaHoraria, Requisito requisito)
            : this(nombre, año, cargaHoraria)
        {
            Requisitos.Add(requisito);
        }


        public void AgregarExamen(Examen examen)
        {
            if (examen == null)
                throw new ArgumentNullException("examen", "No debe ser nulo.");
            if (examen.MateriaCorrespondiente != this)
                throw new ArgumentException("examen", "Debe pertenecer a esta materia.");
            
            Examenes.Add(examen);
            calcularEstadoMateria();
        }

        public override string ToString()
        {
            StringBuilder requisitoMensajeBuilder;
            string mensajeRequisito = "";

            if (Requisitos != null && Requisitos.Count > 0)
            {
                requisitoMensajeBuilder = new StringBuilder();

                foreach (var req in Requisitos)
                {
                    requisitoMensajeBuilder.AppendLine(req.ToString());
                }
                mensajeRequisito = requisitoMensajeBuilder.ToString();
            }
            else
            {
                mensajeRequisito = " No tiene requisitos.";
            }

            return Nombre + " \nRequiere:" + mensajeRequisito;
        }

    }
}
