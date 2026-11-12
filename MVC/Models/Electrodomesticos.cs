using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Electrodomesticos
    {
        [Required(ErrorMessage = "El tipo es obligatorio")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        public string Modelo { get; set; }

        // Precio del electrodoméstico nuevo (para compararlo con el coste de la reparación)
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Precio { get; set; }
    }
}
