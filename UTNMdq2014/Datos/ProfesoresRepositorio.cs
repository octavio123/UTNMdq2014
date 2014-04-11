using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Datos
{
    public class ProfesoresRepositorio : Repositorio<Profesor>
    {
        public BindingList<Profesor> Profesores { get; set; }
        static string RepoFile = "profesores.xml";

        public ProfesoresRepositorio() : base(RepoFile)
        {
            Profesores = new BindingList<Profesor>(base.Datos);
        }

    }
}
