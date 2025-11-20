using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_proyecto_sena.services
{
    
    public interface IPasswoedservice
    {
        string Hashpassword(String password,out string salt);
        bool compararContraseña(string contraseña, string contraseñaBD, string salt);
    }
}