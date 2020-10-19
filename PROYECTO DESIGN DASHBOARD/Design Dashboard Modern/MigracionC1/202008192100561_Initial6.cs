namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VentasItems", "Codigo", "dbo.Producto");
            DropIndex("dbo.VentasItems", new[] { "Codigo" });
            RenameColumn(table: "dbo.VentasItems", name: "Codigo", newName: "producto_Codigo");
            AlterColumn("dbo.VentasItems", "producto_Codigo", c => c.Int());
            CreateIndex("dbo.VentasItems", "producto_Codigo");
            AddForeignKey("dbo.VentasItems", "producto_Codigo", "dbo.Producto", "Codigo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentasItems", "producto_Codigo", "dbo.Producto");
            DropIndex("dbo.VentasItems", new[] { "producto_Codigo" });
            AlterColumn("dbo.VentasItems", "producto_Codigo", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.VentasItems", name: "producto_Codigo", newName: "Codigo");
            CreateIndex("dbo.VentasItems", "Codigo");
            AddForeignKey("dbo.VentasItems", "Codigo", "dbo.Producto", "Codigo", cascadeDelete: true);
        }
    }
}
