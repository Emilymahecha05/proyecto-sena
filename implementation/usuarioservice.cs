using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using mi_proyecto_sena.Data;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mi_proyecto_sena.implementation
{
    public class usuarioservice : Iusuarioservice
    {
        private readonly DBcontext dBcontext;
        public usuarioservice(DBcontext dBcontext)
        { 
            this.dBcontext = dBcontext;

        }

        public async void crearUsuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                dBcontext.usuarios.Add(usuario);
                await dBcontext.SaveChangesAsync();

            } 
        }

        public void CrearUsuario(usuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
