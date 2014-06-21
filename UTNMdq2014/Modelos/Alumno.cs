using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Alumno
    {
        private string nombre, email, telefono, dni;

        #region Propiedades
        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (Validador.EsTelefonoValido(value))
                {
                    telefono = value;
                }
                else
                {
                    throw new ArgumentException("telefono", "El valor especificado es inválido.");
                }
            }

        }
        
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (Validador.EsEmailValido(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("email", "El valor especificado es inválido.");
                }
            }

        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (Validador.EsNombreValido(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("nombre", "El valor especificado es inválido.");
                }
            }
        }

        public DateTime Nacimiento { get; set; }
        
        public DateTime Ingreso { get; set; }

        public int AlumnoId { get; set; }

        public List<Legajo> Legajos { get; set; }

        #endregion

        public Alumno()
        {
            Nacimiento = Ingreso = DateTime.Now;
        }

        public Alumno ( string nombre, string telefono, string email,
                      DateTime nacimiento, DateTime ingreso )
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Nacimiento = nacimiento;
            Ingreso = ingreso;
            Legajos = new List<Legajo>();
        }

        public Alumno(Alumno otro)
            : this( otro.Nombre, otro.Telefono, otro.Email,
                   otro.Nacimiento, otro.Ingreso )
        {
            Legajos = otro.Legajos;
        }

        /// <summary>
        /// Añade un legajo asociado al alumno.
        /// </summary>
        /// <param name="legajo">Un <see cref="Legajo"/>.</param>
        public void AñadirLegajo(Legajo legajo)
        {
            if (legajo == null)
            {
                string message = "El legajo a agregar no puede ser nulo.";
                throw new ArgumentNullException("legajo", message);
            }

            Legajos.Add(legajo);
        }

        public override string ToString()
        {
            return Nombre + " " + Telefono + " " + Email + " " + Nacimiento;
        }
    }
}
