using UTNMdq2014.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UTNMdq2014.Tests
{
    [TestClass()]
    public class PlanEstudioTest
    {
        private static PlanEstudio GetNormalPlanEstudio()
        {
            return new PlanEstudio();
        }

        private static PlanEstudio GetFilledPlanEstudio()
        {
            PlanEstudio p = new PlanEstudio();
            Materia a, b, c;
            a = new Materia("Matematica", 2014, 43);
            b = new Materia("Estadistica", 2014, 43);
            c = new Materia("Investigacion Operativa", 2014, 43);

            Requisito ra, rb;
            ra = new Requisito(a, true, true);
            rb = new Requisito(b, true, false);

            p.AgregarMateria(a);
            p.AgregarMateria(b, ra);
            p.AgregarMateria(c, rb);

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
        }

    }
}
