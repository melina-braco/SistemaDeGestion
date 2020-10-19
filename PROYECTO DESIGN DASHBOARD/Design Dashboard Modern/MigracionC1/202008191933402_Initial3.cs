namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VentasItems", "IdProducto", "dbo.Producto");
            DropIndex("dbo.VentasItems", new[] { "IdProducto" });
            RenameColumn(table: "dbo.VentasItems", name: "IdProducto", newName: "producto_IdProducto");
            AddColumn("dbo.VentasItems", "Codigo", c => c.Int(nullable: false));
            AlterColumn("dbo.VentasItems", "producto_IdProducto", c => c.Int());
            CreateIndex("dbo.VentasItems", "producto_IdProducto");
            AddForeignKey("dbo.VentasItems", "producto_IdProducto", "dbo.Producto", "IdProducto");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentasItems", "producto_IdProducto", "dbo.Producto");
            DropIndex("dbo.VentasItems", new[] { "producto_IdProducto" });
            AlterColumn("dbo.VentasItems", "producto_IdProducto", c => c.Int(nullable: false));
            DropColumn("dbo.VentasItems", "Codigo");
            RenameColumn(table: "dbo.VentasItems", name: "producto_IdProducto", newName: "IdProducto");
            CreateIndex("dbo.VentasItems", "IdProducto");
            AddForeignKey("dbo.VentasItems", "IdProducto", "dbo.Producto", "IdProducto", cascadeDelete: true);
        }
    }
}
