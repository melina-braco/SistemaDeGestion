using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Design_Dashboard_Modern.Models
{
    [Table("VentasItems")]
    class ModelsVentaItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVentasItems { get; set; }

        [Required(ErrorMessage = "El campo Cantidad no puede estar vacio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo Precio Costo no puede estar vacio")]
        public decimal PrecioVenta { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        public int IdVentas { get; set; }
       
        public virtual ModelsVentas venta { get; set; }

        #region campos asociados al producto

        public int Codigo { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Precio Costo no puede estar vacio")]
        public decimal PrecioCosto { get; set; }

        public virtual ModelsProducto producto { get; set; }

        #endregion

        public DateTime FechaEgreso { get; set; }

    }
}