using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Design_Dashboard_Modern.Models
{
    [Table("Ventas")]
    class ModelsVentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVentas { get; set; }

        [Required(ErrorMessage = "El campo Producto no puede estar vacio")]
        public decimal Total { get; set; }

        [StringLength(50, ErrorMessage = "No ingrese más de 50 caracteres")]
        public string Observacion { get; set; }

        public DateTime FechaEgreso { get; set; }

        public virtual ICollection <ModelsVentaItems> ventaItems { get; set; }

        public int IdCliente { get; set; }

        public virtual ModelsCliente cliente { get; set; }
    }
}