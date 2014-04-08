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
    public class AlumnosRepositorio : Repositorio<Alumno>
    {
        public List<Alumno> Alumnos { get; set; }
        static string RepoFile = "Alumnos.xml";

        public AlumnosRepositorio() : base(RepoFile)
        {
            Alumnos = base.Datos;
        }

    }
}
