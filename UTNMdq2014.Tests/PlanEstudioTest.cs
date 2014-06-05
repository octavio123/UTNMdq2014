using UTNMdq2014.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UTNMdq2014.Tests
{
    [TestClass()]
    /// summary
    /// <see cref= "PlanEstudio">
    /// 
    public class PlanEstudioTest
    {
        private static PlanEstudio GetNormalPlanEstudio()
        {
            return new PlanEstudio();
        }

        /// <summary>
        /// Crea un <see cref="PlanEstudio"/> con
        /// tres materias:
        /// "Matematica", "Estadistica", "Investigacion Operativa"
        /// </summary>
        /// <returns></returns>
        private static PlanEstudio GetFilledPlanEstudio()
        {
            PlanEstudio p = new PlanEstudio();
            Materia a, b, c;
            a = new Materia("Matematica", 2014, 43);
            b = new Materia("Estadistica", 2014, 43);
            c = new Materia("Investigacion Operativa", 2014, 43);

            Requisito rb, rc;
            rb = new Requisito(a, true, false); // Estadistica requiere cursada Matematica
            rc = new Requisito(b, true, true); // Investigacion Operativa requiere cursada y aprobada Estadistica

            p.AgregarMateria(a);
            p.AgregarMateria(b, rb);
            p.AgregarMateria(c, rc);

            return p;
        }

        [TestMethod()]
        public void PuedeCursarseTest()
        {
            PlanEstudio target = GetFilledPlanEstudio();
            Assert.IsTrue(target.EstaHabilitada("Matematica"));
        }

        [TestMethod()]
        public void AgregarMateriaTest()
        {
            PlanEstudio target = new PlanEstudio();
            Materia m = new Materia("Matematica", 2014, 43);

            int materiasEsperadas = 1;

            target.AgregarMateria(m);

            Assert.AreEqual(materiasEsperadas, target.ObtenerMaterias().Count);
            Assert.AreEqual(materiasEsperadas, target.Correlatividades.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AgregarMateriaNulaFalla()
        {
            Materia n = null;
            PlanEstudio target = new PlanEstudio();

            target.AgregarMateria(n);
        }

        [TestMethod()]
        public void PuedeCursarseSinRequisitos()
        {
            PlanEstudio target = new PlanEstudio();
            Materia a = new Materia("Matematica", 2011, 43);

            target.AgregarMateria(a);
            
            Assert.IsTrue(target.EstaHabilitada(a));
        }

        [TestMethod()]
        public void MateriaConRequisitosIncumplidosNoHabilitada()
        {
            PlanEstudio target = new PlanEstudio();

            Materia estadistica = new Materia("Estadistica", 2011, 42);
            Materia investigacion = new Materia("Investigacion Operativa II", 2014, 54);

            // Examen desaprobado = materia desaprobada
            estadistica.AgregarExamen(new Examen(estadistica, 3, false));

            Requisito rinvestigacion = new Requisito(estadistica, true, true);
            var requisitos = new List<Requisito>();
            requisitos.Add(rinvestigacion);

            target.AgregarMateria(estadistica);
            target.AgregarMateria(investigacion, requisitos);

            Assert.IsFalse(target.EstaHabilitada(investigacion));

        }

    }
}
