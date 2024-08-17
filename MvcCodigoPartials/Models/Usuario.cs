using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCodigoPartials.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(5, ErrorMessage = "El nombre no puede tener más de 5 caracteres")]
        public string Nombre { get; set; }
        [Range(18, 65, ErrorMessage = "La edad debe estar entre 18 y 65 años")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        public string Email { get; set; }
    }
}