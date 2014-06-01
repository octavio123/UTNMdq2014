using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Aula
    {
        public string Nombre {set; get;}
        public int Capacidad {set; get;}
        public int Computadoras {set; get;}
        public bool Proyector {set; get}
        
        int piso;    
        string sector;
        
        public Aula()
        {
            Nombre =""";
        }
        
        public Aula (string nombre, int cap, int comp, int piso, string sector, bool proyector)
        {
            Nombre = nombre;
            Capacidad = cap;
            Computadoras = comp;
            this.piso = piso;
            this.sector = sector;
            Proyector = proyector;
        }
    
    }
}
