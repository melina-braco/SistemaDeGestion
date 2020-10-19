using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Design_Dashboard_Modern.Models
{
    class DBContext : DbContext
    {
        public DBContext() : base()
        {


        }
        public DBContext(string connStrin) : base(connStrin)
        {
            

        }

        public virtual DbSet<ModelsProducto> ModeloProducto { get; set; }

        public virtual DbSet<ModelsVentas> ModeloVentas { get; set; }

        public virtual DbSet<ModelsVentaItems> ModeloVentaItems { get; set; }

        public virtual DbSet<ModelsCliente> ModeloCliente { get; set; }

        public virtual DbSet<ModelsProveedor> ModeloProveedor { get; set; }

        public virtual DbSet<ModelsUsuario> ModeloUsuario { get; set; }

        public virtual DbSet<ModelsEmpresa> ModeloEmpresa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        
        }

    }
}
