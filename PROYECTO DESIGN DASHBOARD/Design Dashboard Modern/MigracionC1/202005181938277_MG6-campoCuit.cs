namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MG6campoCuit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Cuit", c => c.String(nullable: false));
            AddColumn("dbo.Empresa", "Cuit", c => c.String(nullable: false));
            AddColumn("dbo.Proveedor", "Cuit", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proveedor", "Cuit");
            DropColumn("dbo.Empresa", "Cuit");
            DropColumn("dbo.Cliente", "Cuit");
        }
    }
}
