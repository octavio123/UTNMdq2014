using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public struct DescripcionAula
    {
        public int capacidad, computadoras, piso;
        public string nombre, sector;
        public bool proyector;
    }

    public class Aula
    {
        private string nombre, sector;
        private int capacidad, cantidadComputadoras, piso;
        private bool proyector;

        #region Propiedades

        public DescripcionAula Descripcion { get; set; }

        public string Nombre { set { nombre = value; } get { return nombre; } }

        public int Capacidad { set { capacidad = value; } get { return capacidad; } }

        public int Computadoras { set { cantidadComputadoras = value; } get { return cantidadComputadoras; } }

        public bool Proyector { set { proyector = value; } get { return proyector; } }

        public int Piso { set { piso = value; } get { return piso; } }

        public string Sector { set { sector = value; } get { return sector; } }

        #endregion

        #region Contructores

        public Aula()
        {
        }

        public Aula (DescripcionAula datos)
        {
            Nombre = datos.nombre;
            Capacidad = datos.capacidad;
            Computadoras = datos.computadoras;
            Piso = datos.piso;
            Sector = datos.sector;
            Proyector = datos.proyector;
        }

        public Aula(Aula a)
        {
            setDescripcion(a.Descripcion);
            Nombre = a.Nombre;
            Capacidad = a.Capacidad;
            Computadoras = a.Computadoras;
            Piso = a.Piso;
            Sector = a.Sector;
            Proyector = a.Proyector;
        }

        /// <summary>
        /// Cambia los datos del aula.
        /// </summary>
        /// <param name="datos">Una <see cref="DescripcionAula"/>.</param>
        private void setDescripcion(DescripcionAula datos)
        {
            Nombre = datos.nombre;
            Capacidad = datos.capacidad;
            Computadoras = datos.computadoras;
            Piso = datos.piso;
            Sector = datos.sector;
            Proyector = datos.proyector;
        }

        #endregion

        #region Metodos

        #endregion
    }
}
