using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Datos
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        public BindingList<Usuario> Usuarios { get; set; }
        static string RepoFile = "usuarios.xml";

        public UsuarioRepositorio() : base(RepoFile)
        {
            Usuarios = new BindingList<Usuario>(base.Datos);
        }

    }
}
