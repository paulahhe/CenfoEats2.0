using CenfoEats2._0.PMetodoFabrica.Creador;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PMetodoFabrica.CreadorConcreto
{
    public class Creador_Usuarios : I_Creador_Usuarios
    {
        public override Usuario CrearUsuario(string nombre, string correo_electronico, string telefono, string tipo, string contrasenna)
        {
            if (tipo == "Cliente")
            {
                return new Cliente(nombre, correo_electronico, telefono, contrasenna);
            }
            else if (tipo == "Repartidor")
            {
                return new Repartidor(nombre, correo_electronico, telefono, contrasenna);
            }
            else
            {
                return null;
            }

        }
    }
}
