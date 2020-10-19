namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentasItems", "PrecioVenta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VentasItems", "PrecioCosto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.VentasItems", "Precio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VentasItems", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.VentasItems", "PrecioCosto");
            DropColumn("dbo.VentasItems", "PrecioVenta");
        }
    }
}
