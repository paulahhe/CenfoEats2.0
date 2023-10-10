using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PMetodoFabrica.ProductoConcreto
{
    class Cliente : Usuario
    {
        public Cliente(string nombre, string correo_electronico, string telefono, string contrasenna) : base(nombre, correo_electronico, telefono, contrasenna)
        {
            tipo = "Cliente";
        }

        
       
    }
}
