using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Design_Dashboard_Modern.Models
{
    [Table("Usuario")]
    class ModelsUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El campo Usuario no puede estar vacio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "El campo Contraseña no puede estar vacio")]
        public string Contraseña { get; set; }

        [Compare("Contraseña", ErrorMessage = "La clave y la verificación de la clave no coinciden")]
        public string PasswordConfirmacion { get; set; }

        public DateTime FechaAlta { get; set; }
    }
}