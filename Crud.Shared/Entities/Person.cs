using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Name { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? LastName { get; set; }

        [Display(Name = "Edad")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Range(0, 150, ErrorMessage = "Debe tener una edad entre 0 y 150 años")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int? Age { get; set; }



        public int GenderId { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? gender { get; set; }
    }
}
