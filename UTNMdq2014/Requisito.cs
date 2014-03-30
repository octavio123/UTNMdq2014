using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    /// <summary>
    /// El requisito contiene una 
    /// especificación de estado de aprobada y cursada. 
    /// </summary>
    public class Requisito
    {

        bool aprobada, cursada;

        Materia materia;

        /// <summary>
        /// Retorna según las condiciones de cursada y aprobada si
        /// se encuentra cumplido.
        /// </summary>
        public bool Cumplido
        {
            get
            {
                if (materia == null)
                {
                    string message = "La materia correspondiente al requisito se volvió nula";
                    throw new ArgumentNullException("materia", message); 
                }

                return ( materia.Aprobada == aprobada &&
                         materia.Cursada == cursada);
            }
        }

        /// <summary>
        /// Establece un requisito.
        /// </summary>
        /// <param name="cursada">Debe encontrarse cursada la materia.</param>
        /// <param name="aprobada">Debe encontrarse aprobada la materia.</param>
        public Requisito(Materia materia, bool cursada, bool aprobada)
        {
            this.materia = materia;
            this.aprobada = aprobada;
            this.cursada = cursada;
        }

        public override string ToString()
        {
            return " Aprobada:" + aprobada +
                   " Cursada:" + cursada +
                   "\n" + "["+materia+"]";
        }

    }
}
