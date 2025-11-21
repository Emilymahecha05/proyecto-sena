using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Data;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.services;
using Microsoft.EntityFrameworkCore;

namespace mi_proyecto_sena.implementation
{
    public class loginservice : Iloginservice

    {
        private readonly DBcontext dBcontext;
        private readonly IPasswoedservice passwoedservice;

        public loginservice(DBcontext dBcontext, IPasswoedservice passwoedservice)
        {
            this.dBcontext = dBcontext;
            this.passwoedservice = passwoedservice;
        }
        public async Task<usuarioModel?> login(loginModel login)
        {
            var usuario = await dBcontext.usuarios.FirstOrDefaultAsync(u => u.usuario_correo == login.login_correo);
            if (usuario == null)
            {
                return null;
            }
            bool esContrasenaValida = passwoedservice
            .compararContraseña(login.login_contraseña, usuario.usuario_contraseña, usuario.usuario_salt!);
            if (esContrasenaValida)
            {
                return usuario;
            }
            return null;
        }
    }
}