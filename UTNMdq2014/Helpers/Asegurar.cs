using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Helpers
{
    public static class Asegurar
    {
        /// <summary>
        /// Arroja una ArgumentNullException en caso de que el objeto sea nulo
        /// con el nombre y mensaje especificado.
        /// </summary>
        public static void NoEsNulo(object obj, string name, string message)
        {
            if (obj == null) { throw new ArgumentNullException(name, message); }
        }
    }
}
