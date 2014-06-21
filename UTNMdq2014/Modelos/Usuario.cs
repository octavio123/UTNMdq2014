using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTNMdq2014.Login;

namespace UTNMdq2014.Modelos
{

    public enum UsuarioTipo // UserType :P
    {
        Profesor, Administrador, Mantenedor, Consultor
    }

    public class Usuario
    {
        public UsuarioTipo Tipo { get; set; }
        public string Nombre { get; set; }
        public PasswordHash Contraseña { get; set; }

        public Usuario(string nombre, string contraseña, UsuarioTipo tipo, string salt = null)
        {
            PasswordHash hash;

            Nombre = nombre;

            Tipo = tipo;

            if (salt == null)
            {
                hash = PasswordHashFactory.HashPassword(contraseña); 
            }
            // Generate hash from saved salt (when comparing to db user account)
            else
            {
                hash = PasswordHashFactory.HashPasswordWithSalt(contraseña, salt);
            }

            this.Contraseña = hash;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }
    }
}
