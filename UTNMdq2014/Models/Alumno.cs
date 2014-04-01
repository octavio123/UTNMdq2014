using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
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

        public virtual Fecha Nacimiento { get; set; }
        
        public virtual Fecha Ingreso { get; set; }

        #endregion

        public int AlumnoId { get; set; }

        public virtual List<Legajo> Legajos { get; set; }

        public Alumno()
            : this("Indefinido", "Indefinido", "indefinido@nada.com", new Fecha(1, 1, 1), new Fecha(1, 1, 1))
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
