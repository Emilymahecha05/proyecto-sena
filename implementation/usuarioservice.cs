using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Data;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.services;

namespace mi_proyecto_sena.implementation
{
    public class usuarioservice : Iusuarioservice
    {
        public void crearUsuario(usuarioModel usuario)
        {
            throw new NotImplementedException();
        }
        private readonly DBcontext dBcontext;
        public usuarioservice(DBcontext dBcontext)
        {
            this.dBcontext = dBcontext;
        }
    }
}