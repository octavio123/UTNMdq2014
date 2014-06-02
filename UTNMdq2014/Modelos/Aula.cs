using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Aula
    {
        private string nombre, sector;
        private int capacidad, cantidadComputadoras, piso;
        private bool proyector;

        #region Propiedades

        public string Nombre {set {nombre = value;} get { return nombre;}}
        
        public int Capacidad {set {capacidad = value;} get {return capacidad;}}
        
        public int Computadoras {set{cantidadComputadoras = value} get{return cantidadComputadoras;}}
        
        public bool Proyector { set { proyector = value; } get { return proyector; } }

        public int Piso { set { piso = value; } get { return piso; } }

        public string Sector { set { sector = value; } get { return sector; } }
        
        #endregion

        #region Contructores
        /// <summary>
        /// 
        /// </summary>
        /// 

        public Aula()
        {
            Nombre ="";
            Proyector = false;
        }
        
        public Aula (string nombre, int cap, int comp, int piso, string sector, bool proyector)
        {
            Nombre = nombre;
            Capacidad = cap;
            Computadoras = comp;
            Piso = piso;
            Sector = sector;
            Proyector = proyector;
        }

        public Aula(Aula a)
        {
            Nombre = a.Nombre;
            Capacidad = a.Capacidad;
            Computadoras = a.Computadoras;
            Piso = a.Piso;
            Sector = a.Sector;
            Proyector = a.Proyector;
        }

        #endregion

        #region Metodos

        #endregion

    }
}
