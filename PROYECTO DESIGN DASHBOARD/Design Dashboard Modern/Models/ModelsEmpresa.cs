using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Design_Dashboard_Modern.Models
{
    [Table("Empresa")]
    class ModelsEmpresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = "El campo Nombre no puede estar vacio")]
        public string Nombre  { get; set; }

        public string Descripcion { get; set; }
       
        public string Domicilio { get; set; }
   
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Cuit no puede estar vacio")]
        public string Cuit { get; set; }

        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "El campo Mail no puede estar vacio")]
        [RegularExpression("^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$", ErrorMessage = "El Formato del Mail es incorrecto")]
        public string Mail { get; set; }

    }
}