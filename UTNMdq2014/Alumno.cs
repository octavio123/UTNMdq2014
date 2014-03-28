using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Alumno
    {
        private string nombre, email, telefono;

        #region Propiedades
        public string Telefono
        {
            get { return telefono; }
            protected set
            {
                if (ValidadorPersona.EsTelefonoValido(value))
                    telefono = value;
                else
                    throw new ArgumentException("telefono", "El valor especificado es inválido.");
            }

        }

        public string Email
        {
            get { return email; }
            protected set
            {
                if (ValidadorPersona.EsEmailValido(value))
                    email = value;
                else
                    throw new ArgumentException("email", "El valor especificado es inválido.");
            }

        }
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

        public Fecha Nacimiento { get; protected set; }
        public Fecha Ingreso { get; protected set; }
        
        #endregion

        public Alumno()
            : this("", "", "", new Fecha(0, 0, 0), new Fecha(0, 0, 0))
        {
        }

        public Alumno(string nombre, string telefono, string email,
                      Fecha nacimiento, Fecha ingreso)
        {
        }

        public Alumno(Alumno otro)
            : this(otro.Nombre, otro.Telefono, otro.Email,
                   otro.Nacimiento, otro.Ingreso)
        {
        }
    }
}
