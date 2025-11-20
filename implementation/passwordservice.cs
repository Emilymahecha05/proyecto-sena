using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading.Tasks;
using mi_proyecto_sena.services;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mi_proyecto_sena.implementation
{
    public class passwordservice : IPasswoedservice
    {
        public bool compararContraseña(string contraseña, string contraseñaBD, string salt)
        {
            throw new NotImplementedException();
        }

        public string Hashpassword(string password, out string salt)
        {
         string hashedpassword;
            byte[] SaltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(SaltBytes);
            }
            salt = Convert.ToBase64String(SaltBytes);
            hashedpassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
               password: password,
               salt: SaltBytes,
               prf: KeyDerivationPrf.HMACSHA256,
               iterationCount: 100000,
               numBytesRequested: 256 / 8));
            return hashedpassword;

            }
        }
    }  