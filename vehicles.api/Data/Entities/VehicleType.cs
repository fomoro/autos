using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vehicles.api.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }
        
        [Display(Name = "Typo de Vehiculo")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tenener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        public string Description { get; set; }
    }
}
