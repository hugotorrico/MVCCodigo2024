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

       
        public string Nombre { get; set; }

      
        public string Email { get; set; }
    }
}