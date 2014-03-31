using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
{
    public class Materia
    {

        static readonly int notaMinima = 4;

        string nombre;

        int sumaNotas, // Suma de la nota de todos los examenes.
            cantidadParciales,
            cantidadFinales,
            parcialesAprobados,
            finalesAprobados;

        

        #region Propiedades

        public List<Requisito> Condiciones { get; set; }
        public List<Examen> Examenes { get; set; }

        public int MateriaId { get; set; }

        /// <summary>
        /// Calcula el promedio que se obtubo en la materia.
        /// </summary>
        public float Promedio
        {
            get { return ((float)sumaNotas / (cantidadFinales + cantidadFinales)); }
        }

        /// <summary>
        /// Muestra si la materia se encuentra en condiciones de
        /// ser cursada en base al <b>Requisito</b>.
        /// </summary>
        public bool CursadaHabilitada
        {
            get 
            { 
                return Condiciones == null || Condiciones.All(requisito => requisito.Cumplido);
            }
        }

        /// <summary>
        /// Determina si la materia se encuentra aprobada.
        /// </summary>
        public bool Aprobada 
        { 
            get
            {
                return (Cursada && (cantidadFinales == finalesAprobados));
            }
        }

        /// <summary>
        /// Determina si la materia se encuentra cursada.
        /// </summary>
        public bool Cursada
        {
            get
            {
                return ( CargaHoraria == HorasCursadas &&
                         parcialesAprobados == cantidadParciales );
            }
        }

        public string Nombre
        {
            get { return nombre; }
            protected set
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
            protected set;
        }

        public int CargaHoraria { get; protected set; }

        public int HorasCursadas { get; protected set; }
        
        #endregion

        private void calcularEstadoMateria()
        {

            sumaNotas =
            cantidadParciales =
            parcialesAprobados =
            cantidadFinales =
            finalesAprobados = 0;

            foreach (var examen in Examenes)
            {
                if (examen.Parcial)
                {
                    cantidadParciales++;
                    if (examen.Nota >= notaMinima)
                        parcialesAprobados++;
                }
                else
                {
                    cantidadFinales++;
                    finalesAprobados += (examen.Nota >= notaMinima) ? 1 : 0;
                }

                sumaNotas += examen.Nota;
            }
        }

        public Materia() : this("Indefinido", 0, 0)
        {
        }

        public Materia(string nombre, int año, int cargaHoraria, List<Requisito> requisitos = null)
        {
            Nombre = nombre;
            Año = año;
            Condiciones = requisitos;
            CargaHoraria = cargaHoraria;

            Examenes = new List<Examen>();
        }

        public Materia (string nombre, int año, int cargaHoraria, Requisito requisito)
            : this(nombre, año, cargaHoraria, new List<Requisito>(new Requisito[] { requisito }))
        {
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

            if (Condiciones != null)
            {
                requisitoMensajeBuilder = new StringBuilder();

                foreach (var req in Condiciones)
                {
                    requisitoMensajeBuilder.AppendLine(req.ToString());
                }
                mensajeRequisito = requisitoMensajeBuilder.ToString();
            }
            else
            {
                mensajeRequisito = " No tiene requisitos.";
            }

            return Nombre + "\nRequiere:" + mensajeRequisito;
        }

    }
}
