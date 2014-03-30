using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Materia
    {

        static readonly int notaMinima = 4;

        List<Examen> examenes;
        
        string nombre;

        int sumaNotas, // Suma de la nota de todos los examenes.
            cantidadParciales,
            cantidadFinales,
            parcialesAprobados,
            finalesAprobados;

        Requisito[] condiciones;

        #region Propiedades

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
                return condiciones == null || condiciones.All(requisito => requisito.Cumplido);
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

            foreach (var examen in examenes)
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


        public Materia(string nombre, int año, int cargaHoraria, Requisito[] requisitos = null)
        {
            Nombre = nombre;
            Año = año;
            condiciones = requisitos;
            CargaHoraria = cargaHoraria;

            examenes = new List<Examen>();
        }

        public Materia (string nombre, int año, int cargaHoraria, Requisito requisito)
            : this(nombre, año, cargaHoraria, new Requisito[] { requisito } )
        {
        }


        public void AgregarExamen(Examen examen)
        {
            if (examen == null)
                throw new ArgumentNullException("examen", "No debe ser nulo.");
            if (examen.MateriaCorrespondiente != this)
                throw new ArgumentException("examen", "Debe pertenecer a esta materia.");
            
            examenes.Add(examen);
            calcularEstadoMateria();
        }

        public override string ToString()
        {
            StringBuilder requisitoMensajeBuilder;
            string mensajeRequisito = "";

            if (condiciones != null)
            {
                requisitoMensajeBuilder = new StringBuilder();

                foreach (var req in condiciones)
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
