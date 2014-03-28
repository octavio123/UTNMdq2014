using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    /// <summary>
    /// Contiene dia, mes y año.
    /// </summary>
    class Fecha
    {
        
        public int Dia { set; get; }
        public int Mes { set; get; }
        public int Año { set; get; }

        public Fecha()
        {
            Dia = Mes = Año = 0;
        }

        public Fecha(int dia, int mes, int año)
        {
            Dia = dia;
            Mes = mes;
            Año = año;
        }

        public Fecha(Fecha otra)
        {
            Dia = otra.Dia;
            Mes = otra.Mes;
            Año = otra.Año;
        }

        public override string ToString()
        {
            return Dia + "/" + Mes + "/" + Año;
        }

    }
}
