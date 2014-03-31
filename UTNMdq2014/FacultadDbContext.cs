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
       // public DbSet<Fecha> Fechas { get; set; }
      //public DbSet<Materia> Materias { get; set; }
      //public DbSet<Profesor> Profesores { get; set; }
      //public DbSet<Carrera> Carreras { get; set; }

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
            context.Alumnos.Add(
                new Alumno(
                    "Pedro", 
                    "2312312", 
                    "alguno@werwer.com", 
                    new Fecha(12, 12, 93), 
                    new Fecha(9, 9, 03)));

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
