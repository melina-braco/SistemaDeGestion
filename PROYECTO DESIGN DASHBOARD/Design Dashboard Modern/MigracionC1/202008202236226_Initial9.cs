namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentasItems", "Descripcion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentasItems", "Descripcion");
        }
    }
}
