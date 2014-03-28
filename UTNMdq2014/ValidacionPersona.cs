using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class ValidadorPersona
    {

        public static bool EsEmailValido(string email)
        {
            return ( !string.IsNullOrWhiteSpace(email) &&
                     email.Contains("@") && email.Contains(".com") );
        }

        public static bool EsTelefonoValido(string telefono)
        {
            return ( !string.IsNullOrWhiteSpace(telefono) );
        }

        public static bool EsNombreValido(string nombre)
        {
            return ( !string.IsNullOrWhiteSpace(nombre) );
        }

    }
}
