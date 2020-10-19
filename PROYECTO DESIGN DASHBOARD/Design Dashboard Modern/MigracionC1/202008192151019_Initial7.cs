namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VentasItems", "producto_Codigo", "dbo.Producto");
            DropIndex("dbo.Producto", new[] { "Codigo" });
            DropIndex("dbo.VentasItems", new[] { "producto_Codigo" });
            DropPrimaryKey("dbo.Producto");
            AddColumn("dbo.Producto", "IdProducto", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.VentasItems", "Codigo", c => c.Int(nullable: false));
            AddColumn("dbo.VentasItems", "NombreProducto", c => c.String());
            AddColumn("dbo.VentasItems", "PrecioCosto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Producto", "Codigo", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Producto", "IdProducto");
            CreateIndex("dbo.Producto", "Codigo", unique: true);
            DropColumn("dbo.VentasItems", "producto_Codigo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VentasItems", "producto_Codigo", c => c.Int());
            DropIndex("dbo.Producto", new[] { "Codigo" });
            DropPrimaryKey("dbo.Producto");
            AlterColumn("dbo.Producto", "Codigo", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.VentasItems", "PrecioCosto");
            DropColumn("dbo.VentasItems", "NombreProducto");
            DropColumn("dbo.VentasItems", "Codigo");
            DropColumn("dbo.Producto", "IdProducto");
            AddPrimaryKey("dbo.Producto", "Codigo");
            CreateIndex("dbo.VentasItems", "producto_Codigo");
            CreateIndex("dbo.Producto", "Codigo", unique: true);
            AddForeignKey("dbo.VentasItems", "producto_Codigo", "dbo.Producto", "Codigo");
        }
    }
}
