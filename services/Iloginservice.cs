using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Models;

namespace mi_proyecto_sena.services
{
    public interface Iloginservice
    {
        bool login(loginModel login);
    }
}