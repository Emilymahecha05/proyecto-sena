using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.implementation;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mi_proyecto_sena.Controllers
{
    [Route("user")]
    public class UsuarioController(Iusuarioservice usuarioservice) : Controller
    {
         private readonly Iusuarioservice usuarioservice = usuarioservice;

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register(usuarioModel usuario)
        {
            if (usuario != null)
            {
                await usuarioservice.crearUsuario(usuario);
                return Ok("usuario creado");
            }
            else
            {
                return BadRequest("usuario no puede ser null");
            }
        }
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();    
        }

    }     
}