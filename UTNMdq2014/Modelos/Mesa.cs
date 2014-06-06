using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Mesa
    {
        private string presidente, vocal1, vocal2, tomo, folio, materia, observaciones, secretario, decano;
        private int codigo, inscriptos, examinados, aprobados, ausentes, desaprobados;

        public string Decano { set { decano = value; } get { return decano; } }
        public string Presidente { set { presidente = value; } get { return presidente; } }
        public string Vocal1 { set { vocal1 = value; } get { return vocal1; } }
        public string Vocal2 { set { vocal2 = value; } get { return vocal2; } }

        public string Tomo{ set { tomo = value; } get { return tomo; } }
        public string Folio { set { folio = value; } get { return folio; } }
        public string Materia { set { materia = value; } get { return materia; } }
        public string Observaciones { set { observaciones = value; } get { return observaciones; } }
        
        
        public int Codigo { set { codigo = value; } get { return codigo; } }
        public int Inscriptos { set { inscriptos = value; } get { return inscriptos; } }
        public int Examinados{ set { examinados = value; } get { return examinados; } }
        public int Aprobados { set { aprobados= value; } get { return aprobados; } }
        public int Ausentes { set { ausentes = value; } get { return ausentes; } }
        public int Desaprobados { set { desaprobados= value; } get { return desaprobados; } }
        
        public DateTime Fecha { protected set; get; }


        public Mesa()
        { 
        }

        public Mesa(, List<Alumno> alumnos)
        { 
            
        }
        
        
        
    }
}
