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
                if (ValidadorPersona.EsTelefonoValido(value))
                    telefono = value;
                else
                    throw new ArgumentException("telefono", "El valor especificado es inválido.");
            }

        }
        
        public string Dni
        {
            get {return dni;}
            set {dni = value;}
        }

        public string Email
        {
            get { return email; }
            set
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
            set
            {
                if (ValidadorPersona.EsNombreValido(value))
                    nombre = value;
                else
                    throw new ArgumentException("nombre", "El valor especificado es inválido.");
            }
        }

        public Fecha Nacimiento { get; set; }
        
        public Fecha Ingreso { get; set; }

        public int AlumnoId { get; set; }

        public List<Legajo> Legajos { get; set; }

        #endregion

        public Alumno()
        {
        }

        public Alumno(string nombre, string telefono, string email,
                      Fecha nacimiento, Fecha ingreso)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Nacimiento = nacimiento;
            Ingreso = ingreso;
        }

        public Alumno(Alumno otro)
            : this(otro.Nombre, otro.Telefono, otro.Email,
                   otro.Nacimiento, otro.Ingreso)
        {
        }

        public void AñadirLegajo(Legajo legajo)
        {
            if (legajo == null)
            {
                string message = "El legajo a agregar no puede ser nulo.";
                throw new ArgumentNullException("legajo", message);
            }
            if (Legajos == null)
                Legajos = new List<Legajo>();
            Legajos.Add(legajo);
        }

        public override string ToString()
        {
            return Nombre + " " + Telefono + " " + Email + " " + Nacimiento;
        }
    }
}
