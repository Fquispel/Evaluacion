using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
   
    public class usuarioLogin
    {
        private loginCD log = new loginCD();
        public bool loginUsuario(string nombreUsuario, string passwordUsuario)
        {
            return log.loginUsuario(nombreUsuario, passwordUsuario);
        }
        public bool validarUsuario(string nombreUsuario)
        {
            return log.validarUsuario(nombreUsuario);
        }
    }
}
