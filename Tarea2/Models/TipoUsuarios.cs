using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea2.Models
{
    public class TipoUsuarios
    {
        [Key]
        public int TipoUsuarioId { get; set; }
        public string Nombre { get; set; }
        

    }
}