using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Profesor
    {
        private string nombre, email, telefono;

        public int ProfesorId { get; set; }

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

        public Profesor()
        {
            Nacimiento = DateTime.Now;
            Ingreso = DateTime.Now;
        }

        public Profesor(string nombre, string telefono, string email, 
                        DateTime nacimiento, DateTime ingreso)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Nacimiento = nacimiento;
            Ingreso = ingreso;
        }

        public Profesor(Profesor otro) : this(otro.Nombre, otro.Telefono, otro.Email, otro.Nacimiento, otro.Ingreso)
        {
        }

        public override string ToString()
        {
            return Nombre + " " + Telefono + " " + Email;
        }

        private bool DatosValidos()
        {
            return (!string.IsNullOrWhiteSpace(Nombre) &&
                    !string.IsNullOrWhiteSpace(Email) &&
                    !string.IsNullOrWhiteSpace(Telefono));
        }
    }
}
