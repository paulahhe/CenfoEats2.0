using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PObservador;
using CenfoEats2._0.PObservador.Interfaces;

namespace CenfoEats2._0.PMetodoFabrica.ProductoConcreto
{
    class Repartidor : Usuario, IObservador
    {
        public Repartidor(string nombre, string correo_electronico, string telefono, string contrasenna) : base(nombre, correo_electronico, telefono, contrasenna)
        {
            tipo = "Repartidor";
        }

        public void Update(string status)
        {
            Console.WriteLine($"Repartidor {nombre} ha sido notificado: Estado del pedido - {status}");
        }
    }
    
}
