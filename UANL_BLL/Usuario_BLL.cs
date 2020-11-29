using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UANL_DAL;

namespace UANL_BLL
{
    public class Usuario_BLL
    {
        public Usuario consultarUsuario(string user, string contraseña)
        {
            Usuario_DAL usuario = new Usuario_DAL();
            return usuario.consultarUsuario(user, contraseña);
        }

        public Usuario cargarUsuario(string username)
        {
            Usuario_DAL usuario = new Usuario_DAL();
            return usuario.cargarUsuario(username);
        }

    }
}
