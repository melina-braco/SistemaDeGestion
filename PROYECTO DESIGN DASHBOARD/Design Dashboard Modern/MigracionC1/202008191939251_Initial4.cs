namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentasItems", "Cantidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentasItems", "Cantidad");
        }
    }
}
