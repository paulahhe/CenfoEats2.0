using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using UsuarioDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy.Logica
{
    public class Validador
    {
        private static string rol;


        public static bool ValidarUsuario(string usuario, string pass, int tipo)
        {
            bool tieneAcceso = false;
            SetRole("Ninguno");

            switch (tipo)
            {
                case 1:
                    if (Usuarios.ADMIN.Username == usuario && Usuarios.ADMIN.Password == pass)
                    {
                        tieneAcceso = true;
                        SetRole("Repartidor");
                    }
                    break;

                case 2:
                    if (Usuarios.USER.Username == usuario && Usuarios.USER.Password == pass)
                    {
                        tieneAcceso = true;
                        SetRole("Cliente");
                    }
                    break;
            }

            return tieneAcceso;
        }

        public static string GetRole()
        {
            return _Role;
        }

        private static void SetRole(string role)
        {
            _Role = role;
        }
    }

    // Definición de la clase Usuarios
    public static class Usuarios
    {
        public static readonly Usuario ADMIN = new Usuario("admin", "admin");
        public static readonly Usuario USER = new Usuario("user", "user");
    }

    // Definición de la clase Usuario
    public class Usuario
    {
        public string Username { get; }
        public string Password { get; }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

}

