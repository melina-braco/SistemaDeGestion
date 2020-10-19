namespace Design_Dashboard_Modern.MigracionC1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Mail = c.String(),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Cantidad = c.Int(nullable: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .Index(t => t.Codigo, unique: true);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        IdProveedores = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Mail = c.String(),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProveedores);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false),
                        Contraseña = c.String(nullable: false),
                        PasswordConfirmacion = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
            CreateTable(
                "dbo.VentasItems",
                c => new
                    {
                        IdVentasItems = c.Int(nullable: false, identity: true),
                        Producto = c.String(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdVentas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVentasItems)
                .ForeignKey("dbo.Ventas", t => t.IdVentas, cascadeDelete: true)
                .Index(t => t.IdVentas);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        IdVentas = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacion = c.String(maxLength: 50),
                        FechaEgreso = c.DateTime(nullable: false),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVentas)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentasItems", "IdVentas", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Ventas", new[] { "IdCliente" });
            DropIndex("dbo.VentasItems", new[] { "IdVentas" });
            DropIndex("dbo.Producto", new[] { "Codigo" });
            DropTable("dbo.Ventas");
            DropTable("dbo.VentasItems");
            DropTable("dbo.Usuario");
            DropTable("dbo.Proveedor");
            DropTable("dbo.Producto");
            DropTable("dbo.Cliente");
        }
    }
}
