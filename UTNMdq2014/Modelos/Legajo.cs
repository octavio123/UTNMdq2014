using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UTNMdq2014.Modelos
{
    public class Legajo
    {
        public int LegajoId { get; set; }

        public virtual PlanEstudio Plan { get; set; }

        public override string ToString()
        {
            if (Plan != null)
                return Plan.ToString();
            return "";
        }
    }
}
