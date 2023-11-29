using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PObservador.Interfaces;

namespace CenfoEats2._0.PMetodoFabrica.ProductoConcreto
{
    class Cliente : Usuario, IObservador
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

        public void Update(string status)
        {
            Console.WriteLine($"Cliente {nombre} ha sido notificado: Estado del pedido - {status}");
        }
    }
}
