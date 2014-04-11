using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Datos
{
    public class MateriasRepositorio : Repositorio<Materia>
    {
        public BindingList<Materia> Materias { get; set; }
        static string RepoFile = "materias.xml";
        
        public MateriasRepositorio() : base(RepoFile)
        {
            Materias = new BindingList<Materia>(base.Datos);
        }
    }
}
