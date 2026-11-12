using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Reparacion
    {
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Hora { get; set; }

        // Lo que cuesta la reparación
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Coste { get; set; }

        [Display(Name = "En garantía")]
        public bool Garantia { get; set; }

        // Campos agregados para saber a quién pertenece cada reparación
        [Required(ErrorMessage = "Seleccione un cliente")]
        [Display(Name = "Cliente (DNI)")]
        public string DNICliente { get; set; }

        [Required(ErrorMessage = "Seleccione un técnico")]
        [Display(Name = "Técnico (NIF)")]
        public string NIFTecnico { get; set; }

        [Required(ErrorMessage = "Seleccione un electrodoméstico")]
        [Display(Name = "Electrodoméstico (modelo)")]
        public string ModeloElectrodomestico { get; set; }
    }
}
