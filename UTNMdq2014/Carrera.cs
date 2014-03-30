using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTNMdq2014
{
    public class Carrera
    {
        PlanEstudio plan;
        public PlanEstudio Plan
        {
            get;
            protected set;
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
