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

        public Cliente()
        {
        }

        public Cliente(string nombre, string correo_electronico, string telefono, string contrasenna) : base(nombre, correo_electronico, telefono, contrasenna)
        {
        }

        public Cliente(string nombre, string correo_electronico, string telefono, string tipo, string contrasenna)
        {
            this.nombre = nombre;
            this.correo_electronico = correo_electronico;
            this.telefono = telefono;
            this.tipo = "Cliente";
            this.contrasenna = contrasenna;

        }
    }
}
