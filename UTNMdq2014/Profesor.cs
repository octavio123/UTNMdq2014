using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Profesor
    {
        private string nombre, email, telefono;

        public string Telefono { get { return telefono; } protected set { telefono = value; } }
        public string Email { get { return email; } protected set { email = value; } }
        public string Nombre { get; protected set; }
        public Fecha Nacimiento { get; protected set; }
        public Fecha Ingreso { get; protected set; }

        public Profesor() : this("", "", "", new Fecha(0, 0, 0), new Fecha(0, 0, 0))
        {
        }

        public Profesor(string nombre, string telefono, string email = null, 
                        Fecha nacimiento = null, Fecha ingreso = null)
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
    }
}
