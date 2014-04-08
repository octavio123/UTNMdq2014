using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    /// <summary>
    /// El requisito contiene una 
    /// especificación de estado de aprobada y cursada. 
    /// </summary>
    public class Requisito
    {

        public bool Aprobada { get; set; }
        public bool Cursada { get; set; }

        public int RequisitoId { get; set; }

        public virtual Materia Referida { get; set; }


        /// <summary>
        /// Retorna según las condiciones de cursada y aprobada si
        /// se encuentra cumplido.
        /// </summary>
        public bool Cumplido
        {
            get
            {
                if (Referida == null)
                {
                    string message = "La materia correspondiente al requisito se volvió nula";
                    throw new ArgumentNullException("materia", message); 
                }

                return (Referida.Aprobada == Aprobada &&
                         Referida.Cursada == Cursada);
            }
        }

        /// <summary>
        /// Establece un requisito.
        /// </summary>
        /// <param name="cursada">Debe encontrarse cursada la materia.</param>
        /// <param name="aprobada">Debe encontrarse aprobada la materia.</param>
        public Requisito(Materia materia, bool cursada, bool aprobada)
        {
            Referida = materia;
            Aprobada = aprobada;
            Cursada = cursada;
        }

        public Requisito() : this(null, false, false)
        {
        }

        public override string ToString()
        {
            return "{ Aprobada:" + Aprobada +
                   " Cursada:" + Cursada +
                   " [ " + Referida.Nombre + " ] }";
        }

    }

}
