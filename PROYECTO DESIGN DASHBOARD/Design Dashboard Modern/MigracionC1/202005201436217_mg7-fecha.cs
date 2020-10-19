namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg7fecha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "FechaInicio", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "FechaInicio");
        }
    }
}
