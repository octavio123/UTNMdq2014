using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
{
    /// <summary>
    /// Contiene dia, mes y año.
    /// </summary>
    public class Fecha : IEquatable<Fecha>
    {
        public int FechaId { get; set; }

        public int Dia { protected set; get; }
        public int Mes { protected set; get; }
        public int Año { protected set; get; }

        public Fecha() : this(1, 1, 1)
        {
        }

        public Fecha(int dia, int mes, int año)
        {
            Dia = dia;
            Mes = mes;
            Año = año;
            
            if (!Fecha.EsFechaValida(this))
            {
                throw new ArgumentException("Los valores para la fecha son inválidos.");
            }
        }

        public Fecha(Fecha otra) : this(otra.Dia, otra.Mes, otra.Año)
        {
        }

        public override string ToString()
        {
            return Dia + "/" + Mes + "/" + Año;
        }

        public static Fecha operator+ (Fecha a, Fecha b)
        {
            return new Fecha(a.Dia + b.Dia, a.Mes + b.Mes, a.Año + b.Año);
        }

        public static Fecha operator- (Fecha a, Fecha b)
        {
            return new Fecha(a.Dia - b.Dia, a.Mes - b.Mes, a.Año - b.Año);
        }

        /// <summary>
        /// Compara el dia, mes y año entre dos Fechas.
        /// </summary>
        /// <returns>Verdadero o falso en caso de que sean o no iguales.</returns>
        public bool Equals (Fecha otra)
        {
            return (Dia == otra.Dia &&
                     Mes == otra.Mes &&
                     Año == otra.Año);
        }

        public static bool EsFechaValida(Fecha fecha)
        {
            return ( (fecha.Dia > 0 && fecha.Dia <= 31) &&
                     (fecha.Mes > 0 && fecha.Mes <= 12) &&
                      fecha.Año > 0);
        }
    }
}
