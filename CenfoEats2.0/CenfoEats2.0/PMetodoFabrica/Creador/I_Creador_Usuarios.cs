using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PMetodoFabrica.Creador
{
    public abstract class I_Creador_Usuarios
    {
        public abstract Usuario CrearUsuario(string nombre, string correo_electronico, string telefono, string tipo, string contrasenna);
    }
}
