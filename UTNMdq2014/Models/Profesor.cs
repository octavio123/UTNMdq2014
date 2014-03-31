﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Models
{
    public class Profesor
    {
        private string nombre, email, telefono;

        public int ProfesorId { get; set; }

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
        public Fecha Nacimiento { get; set; }
        public Fecha Ingreso { get; set; }

        public Profesor() : this("Indefinido", "Indefinido", "indefinido@alguno.com", new Fecha(1, 1, 1), new Fecha(1, 1, 1))
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

        private bool DatosValidos()
        {
            return (!string.IsNullOrWhiteSpace(Nombre) &&
                    !string.IsNullOrWhiteSpace(Email) &&
                    !string.IsNullOrWhiteSpace(Telefono));
        }
    }
}
