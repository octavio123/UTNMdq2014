using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public string Contraseña {get; set; }
        
        private string salt;

        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña; // PasswordHash h = PasswordHasher.Hash(contraseña); 
                                     // Contraseña = h.Password;
                                     // salt = h.Salt;
        }
    }
}
