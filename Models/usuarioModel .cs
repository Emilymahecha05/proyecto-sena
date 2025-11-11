using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_proyecto_sena.Models
{
    public class usuarioModel 
    {
        
        public int usuario_Id { get; set; }
        public  required string usuario_Nombre { get; set; }  
        public  required string usuario_Apellido { get; set; }
        public required string usuario_correo { get; set; }
        public required string usuario_contraseña { get; set; }
        
    }
}