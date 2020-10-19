namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MG11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Mail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresa");
        }
    }
}
