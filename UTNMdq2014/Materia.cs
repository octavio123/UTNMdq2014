using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Materia
    {

        static const int notaMinima = 4;
        static const int notaPromocion = 7;

        private List<Examen> examenes;

        int sumaNotas, // Suma de la nota de todos los examenes.
            cantidadParciales, 
            cantidadFinales,
            parcialesAprobados;

        bool aprobada, promocionada;
        public bool Aprobada 
        { 
            get
            {
                // Si no se encuentra aprobado
                if (sumaNotas == 0)
                {
                    calcularSumaNotas();
                    calcularEstadoMateria();
                }
                return aprobada;
            }
        }

        private void calcularEstadoMateria()
        {
            aprobada = (notaMinima <= sumaNotas / examenes.Count);
            promocionada = (notaPromocion <= sumaNotas / examenes.Count);
        }

        private void calcularSumaNotas()
        {
                     sumaNotas =
             cantidadParciales =
            parcialesAprobados =
            cantidadFinales = 0;

            foreach (var examen in examenes)
            {
                if (examen.Parcial)
                {
                    cantidadParciales++;
                    if (examen.Nota >= notaMinima)
                        parcialesAprobados++;
                }
                else
                    cantidadFinales++;

                sumaNotas += examen.Nota;
            }
        }

        public bool Cursada
        {
            get 
            {
                return ( CargaHoraria == HorasCursadas &&
                         parcialesAprobados == cantidadParciales );
            }
        }

        string nombre;
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

        public int CargaHoraria { get; protected set; }
        public int HorasCursadas { get; protected set; }
    }
}
