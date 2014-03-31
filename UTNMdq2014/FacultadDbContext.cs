using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using UTNMdq2014.Models;

namespace UTNMdq2014
{
    public class FacultadDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Fecha> Fechas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Legajo> Legajos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public FacultadDbContext() : base()
        {
            Database.SetInitializer(new FacultadDbInitializer());
        }

       

         
    }

    public class FacultadDbInitializer : DropCreateDatabaseAlways<FacultadDbContext>
    {
        
        protected override void Seed(FacultadDbContext context)
        {
            context.Database.Delete();
            context.Database.Create();

            // Legajo de prueba
            Legajo legajoTest = new Legajo();

            
            // Requisito de prueba
            Materia materiaReqTest = new Materia("Calculo I", 1, 140);
            Requisito requisitoTest = new Requisito(materiaReqTest, true, true);

            // Materia de prueba
            Materia materiaTest = new Materia("Calculo II", 2, 120, requisitoTest);

            // Plan de estudio de prueba
            PlanEstudio planestudioTest = new PlanEstudio();
            planestudioTest.AgregarMateria(materiaTest);
            legajoTest.Plan = planestudioTest;

            // Profesor de prueba
            Profesor profesorTest = new Profesor(
                "Profesor Calculo", 
                "1231323", 
                "alguno@gmail.com", 
                new Fecha(12, 12, 81), 
                new Fecha(12, 12, 02));
            
            // Alumno de prueba
            Alumno alumnoTest = new Alumno(
                    "Pedro",
                    "2312312",
                    "alguno@werwer.com",
                    new Fecha(12, 12, 93),
                    new Fecha(9, 9, 03));

            alumnoTest.AñadirLegajo(legajoTest);

            // Comision de prueba


            // Agregar datos
            context.Legajos.Add(legajoTest);
            context.Alumnos.Add(alumnoTest);
            context.Profesores.Add(profesorTest);
            context.Materias.Add(materiaTest);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbeex)
            {
            }
            catch(DbUpdateException dbuex){ }
        }
    }
}
