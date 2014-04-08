using System;
using System.Collections.Generic;
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
        public List<Profesor> Profesores { get; set; }
        static string RepoFile = "profesores.xml";

        public ProfesoresRepositorio() : base(RepoFile)
        {
            Profesores = base.Datos;
        }

    }
}
