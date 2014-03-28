using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    class Fecha
    {
        /// <summary>
        /// La clase Fecha contiene el dia (dd), mes(mm) y año(aaaa) 
        /// </summary>
       
        int dd, mm, aaaa;

        public int Dd { set; get; }
        public int Mm { set; get; }
        public int Aaaa { set; get; }

        public Fecha()
        {
            this.dd = 0;
            this.mm = 0;
            this.aaaa = 0000;
        }

        public Fecha(int d, int m, int a)
        {
            this.dd = d;
            this.mm = m;
            this.aaaa = a;
        }

        public Fecha(Fecha a)
        {
            this.dd = a.dd;
            this.mm = a.mm;
            this.aaaa = a.aaaa;
        }

        public override string ToString()
        {
            ///Devuelve la cadena dd/mm/aaaa. Ej: 25/5/1810
            ///

            return dd.ToString() + "/" + mm.ToString() + "/" + aaaa.ToString();
        }

    }
}
