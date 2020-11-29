using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UANL_DAL
{
    public class Usuario_DAL
    {
        UANLEntities modelo;

        public Usuario_DAL()
        {
            modelo = new UANLEntities();
        }

        public Usuario consultarUsuario(string usuario, string contraseña)
        {
            var user =
            (from mUsuario in modelo.Usuario
             where mUsuario.username == usuario && mUsuario.password == contraseña
             select mUsuario).FirstOrDefault();
            return user;
        }

        public Usuario cargarUsuario(string username)
        {
            var usuario =
           (from mUsuario in modelo.Usuario
            where mUsuario.username == username
            select mUsuario).FirstOrDefault();
            return usuario;
        }

    }
}
