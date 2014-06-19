using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosas
{
    public class Hora
    {
        //------------------------------------------
        //Atributos

        int hora;
        int minuto;

        //------------------------------------------
        //Constructores

        public Hora()
        {
            hora = 0;
            minuto = 0;
        }

        public Hora(int hora, int minuto)
        {
            this.hora = hora;
            this.minuto = minuto;
        }

        //------------------------------------------
        //Propiedades

        public int Horas
        {
            get { return hora; }
            set { hora = value; }
        }

        public int Minuto
        {
            get { return minuto; }
            set { minuto = value; }
        }

        //------------------------------------------
        //Metodos

        public int Comparar(Hora otro)
        {
            if (hora > otro.hora)
                return 1;
            if (hora < otro.hora)
                return -1;
            if (minuto > otro.minuto)
                return 1;
            if (minuto < otro.minuto)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return hora + ":" + minuto;
        }
    }
}
