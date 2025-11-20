using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mi_proyecto_sena.Models
{
    public class loginModel
    {
        public required string login_correo { get; set; }
        [Required(ErrorMessage = "contraseña obligatorio")]
        [MinLength(6, ErrorMessage = "contraseña debe tener menos de 6 caracteres")]
        public required string login_contraseña { get; set; }

    }
}