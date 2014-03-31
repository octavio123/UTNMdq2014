namespace UTNMdq2014.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Telefono = c.String(),
                        Email = c.String(),
                        Nombre = c.String(),
                        Ingreso_FechaId = c.Int(),
                        Nacimiento_FechaId = c.Int(),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.Fecha", t => t.Ingreso_FechaId)
                .ForeignKey("dbo.Fecha", t => t.Nacimiento_FechaId)
                .Index(t => t.Ingreso_FechaId)
                .Index(t => t.Nacimiento_FechaId);
            
            CreateTable(
                "dbo.Fecha",
                c => new
                    {
                        FechaId = c.Int(nullable: false, identity: true),
                        Dia = c.Int(nullable: false),
                        Mes = c.Int(nullable: false),
                        Año = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FechaId);
            
            CreateTable(
                "dbo.Legajo",
                c => new
                    {
                        LegajoId = c.Int(nullable: false, identity: true),
                        Plan_PlanEstudioId = c.Int(),
                        Alumno_AlumnoId = c.Int(),
                    })
                .PrimaryKey(t => t.LegajoId)
                .ForeignKey("dbo.PlanEstudio", t => t.Plan_PlanEstudioId)
                .ForeignKey("dbo.Alumno", t => t.Alumno_AlumnoId)
                .Index(t => t.Plan_PlanEstudioId)
                .Index(t => t.Alumno_AlumnoId);
            
            CreateTable(
                "dbo.PlanEstudio",
                c => new
                    {
                        PlanEstudioId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PlanEstudioId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Año = c.Int(nullable: false),
                        CargaHoraria = c.Int(nullable: false),
                        HorasCursadas = c.Int(nullable: false),
                        PlanEstudio_PlanEstudioId = c.Int(),
                    })
                .PrimaryKey(t => t.MateriaId)
                .ForeignKey("dbo.PlanEstudio", t => t.PlanEstudio_PlanEstudioId)
                .Index(t => t.PlanEstudio_PlanEstudioId);
            
            CreateTable(
                "dbo.Requisito",
                c => new
                    {
                        RequisitoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.RequisitoId);
            
            CreateTable(
                "dbo.Examen",
                c => new
                    {
                        ExamenId = c.Int(nullable: false, identity: true),
                        Nota = c.Int(nullable: false),
                        Parcial = c.Boolean(nullable: false),
                        MateriaCorrespondiente_MateriaId = c.Int(),
                    })
                .PrimaryKey(t => t.ExamenId)
                .ForeignKey("dbo.Materia", t => t.MateriaCorrespondiente_MateriaId)
                .Index(t => t.MateriaCorrespondiente_MateriaId);
            
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Plan_PlanEstudioId = c.Int(),
                    })
                .PrimaryKey(t => t.CarreraId)
                .ForeignKey("dbo.PlanEstudio", t => t.Plan_PlanEstudioId)
                .Index(t => t.Plan_PlanEstudioId);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Telefono = c.String(),
                        Email = c.String(),
                        Nombre = c.String(),
                        Ingreso_FechaId = c.Int(),
                        Nacimiento_FechaId = c.Int(),
                    })
                .PrimaryKey(t => t.ProfesorId)
                .ForeignKey("dbo.Fecha", t => t.Ingreso_FechaId)
                .ForeignKey("dbo.Fecha", t => t.Nacimiento_FechaId)
                .Index(t => t.Ingreso_FechaId)
                .Index(t => t.Nacimiento_FechaId);
            
            CreateTable(
                "dbo.RequisitoMateria",
                c => new
                    {
                        Requisito_RequisitoId = c.Int(nullable: false),
                        Materia_MateriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Requisito_RequisitoId, t.Materia_MateriaId })
                .ForeignKey("dbo.Requisito", t => t.Requisito_RequisitoId, cascadeDelete: true)
                .ForeignKey("dbo.Materia", t => t.Materia_MateriaId, cascadeDelete: true)
                .Index(t => t.Requisito_RequisitoId)
                .Index(t => t.Materia_MateriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profesor", "Nacimiento_FechaId", "dbo.Fecha");
            DropForeignKey("dbo.Profesor", "Ingreso_FechaId", "dbo.Fecha");
            DropForeignKey("dbo.Carrera", "Plan_PlanEstudioId", "dbo.PlanEstudio");
            DropForeignKey("dbo.Alumno", "Nacimiento_FechaId", "dbo.Fecha");
            DropForeignKey("dbo.Legajo", "Alumno_AlumnoId", "dbo.Alumno");
            DropForeignKey("dbo.Legajo", "Plan_PlanEstudioId", "dbo.PlanEstudio");
            DropForeignKey("dbo.Materia", "PlanEstudio_PlanEstudioId", "dbo.PlanEstudio");
            DropForeignKey("dbo.Examen", "MateriaCorrespondiente_MateriaId", "dbo.Materia");
            DropForeignKey("dbo.RequisitoMateria", "Materia_MateriaId", "dbo.Materia");
            DropForeignKey("dbo.RequisitoMateria", "Requisito_RequisitoId", "dbo.Requisito");
            DropForeignKey("dbo.Alumno", "Ingreso_FechaId", "dbo.Fecha");
            DropIndex("dbo.RequisitoMateria", new[] { "Materia_MateriaId" });
            DropIndex("dbo.RequisitoMateria", new[] { "Requisito_RequisitoId" });
            DropIndex("dbo.Profesor", new[] { "Nacimiento_FechaId" });
            DropIndex("dbo.Profesor", new[] { "Ingreso_FechaId" });
            DropIndex("dbo.Carrera", new[] { "Plan_PlanEstudioId" });
            DropIndex("dbo.Examen", new[] { "MateriaCorrespondiente_MateriaId" });
            DropIndex("dbo.Materia", new[] { "PlanEstudio_PlanEstudioId" });
            DropIndex("dbo.Legajo", new[] { "Alumno_AlumnoId" });
            DropIndex("dbo.Legajo", new[] { "Plan_PlanEstudioId" });
            DropIndex("dbo.Alumno", new[] { "Nacimiento_FechaId" });
            DropIndex("dbo.Alumno", new[] { "Ingreso_FechaId" });
            DropTable("dbo.RequisitoMateria");
            DropTable("dbo.Profesor");
            DropTable("dbo.Carrera");
            DropTable("dbo.Examen");
            DropTable("dbo.Requisito");
            DropTable("dbo.Materia");
            DropTable("dbo.PlanEstudio");
            DropTable("dbo.Legajo");
            DropTable("dbo.Fecha");
            DropTable("dbo.Alumno");
        }
    }
}
