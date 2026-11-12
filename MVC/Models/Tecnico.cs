using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Tecnico
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El NIF es obligatorio")]
        public string NIF { get; set; }

        [Display(Name = "Móvil")]
        public string Movil { get; set; }
    }
}
