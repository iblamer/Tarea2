using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Tarea2.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }


        [Required(ErrorMessage = "Ingrese su nombre completo")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su email")]
        [Display(Name = "Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Por favor ingrese un email correcto")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Ingrese la contrasena")]
        [StringLength(16, ErrorMessage = "La {0} tiene que ser {2} caracteres de largo", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Required(ErrorMessage = "Ingrese el PIN")]
        [StringLength(4, ErrorMessage = "El {0} tiene que ser {2} digitos", MinimumLength = 4)]
        public string Pin { get; set; }

        [Required]
        public int TipoUsuarioId { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy - mm - dd}", ApplyFormatInEditMode = true) ]   
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:999-999-9999}", ApplyFormatInEditMode = true)]
        public string Telefono { get; set; }



    }
}