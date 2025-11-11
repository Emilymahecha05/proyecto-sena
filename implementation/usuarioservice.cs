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
        private readonly IPasswoedservice passwoedservice;
        public usuarioservice(DBcontext dBcontext, IPasswoedservice passwoedservice)
        {
            this.dBcontext = dBcontext;
            this.passwoedservice = passwoedservice;
        }

        public async Task crearUsuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                usuario.usuario_contraseña = passwoedservice.Hashpassword(usuario.usuario_contraseña);
                dBcontext.usuarios.Add(usuario);
                await dBcontext.SaveChangesAsync();

            } 
        }

      
    }
}
