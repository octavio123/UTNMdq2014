using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Carrera
    {
        public int CarreraId { get; set; }
        public List<PlanEstudio> Planes { get; set; }
        public PlanEstudio PlanActual { get; set; }

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (ValidadorPersona.EsNombreValido(value))
                    nombre = value;
                else
                    throw new ArgumentException("nombre", "El valor especificado es inválido.");
            }
        }

        public PlanEstudio Plan
        {
            get;
            set;
        }

        public Carrera(PlanEstudio plan)
        {
            if (plan == null) 
                throw new ArgumentNullException("plan", "El plan no puede ser nulo.");

            Plan = plan;
        }

        public void CambiarPlan(PlanEstudio nuevo)
        {
            Plan = nuevo;
        }
    }
}
