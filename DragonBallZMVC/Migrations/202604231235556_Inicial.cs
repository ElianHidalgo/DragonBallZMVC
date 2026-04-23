namespace DragonBallZMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guerreroes",
                c => new
                    {
                        GuerreroId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Raza = c.String(nullable: false),
                        NivelPoder = c.Int(nullable: false),
                        Transformacion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GuerreroId);
            
            CreateTable(
                "dbo.Tecnicas",
                c => new
                    {
                        TecnicaId = c.Int(nullable: false, identity: true),
                        NombreTecnica = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        NivelDano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TecnicaId);
            
            CreateTable(
                "dbo.TecnicaGuerreroes",
                c => new
                    {
                        Tecnica_TecnicaId = c.Int(nullable: false),
                        Guerrero_GuerreroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tecnica_TecnicaId, t.Guerrero_GuerreroId })
                .ForeignKey("dbo.Tecnicas", t => t.Tecnica_TecnicaId, cascadeDelete: true)
                .ForeignKey("dbo.Guerreroes", t => t.Guerrero_GuerreroId, cascadeDelete: true)
                .Index(t => t.Tecnica_TecnicaId)
                .Index(t => t.Guerrero_GuerreroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TecnicaGuerreroes", "Guerrero_GuerreroId", "dbo.Guerreroes");
            DropForeignKey("dbo.TecnicaGuerreroes", "Tecnica_TecnicaId", "dbo.Tecnicas");
            DropIndex("dbo.TecnicaGuerreroes", new[] { "Guerrero_GuerreroId" });
            DropIndex("dbo.TecnicaGuerreroes", new[] { "Tecnica_TecnicaId" });
            DropTable("dbo.TecnicaGuerreroes");
            DropTable("dbo.Tecnicas");
            DropTable("dbo.Guerreroes");
        }
    }
}
