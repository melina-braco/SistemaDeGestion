namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentasItems", "producto_IdProducto", c => c.Int());
            AlterColumn("dbo.VentasItems", "NombreProducto", c => c.String(nullable: false));
            CreateIndex("dbo.VentasItems", "producto_IdProducto");
            AddForeignKey("dbo.VentasItems", "producto_IdProducto", "dbo.Producto", "IdProducto");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentasItems", "producto_IdProducto", "dbo.Producto");
            DropIndex("dbo.VentasItems", new[] { "producto_IdProducto" });
            AlterColumn("dbo.VentasItems", "NombreProducto", c => c.String());
            DropColumn("dbo.VentasItems", "producto_IdProducto");
        }
    }
}
