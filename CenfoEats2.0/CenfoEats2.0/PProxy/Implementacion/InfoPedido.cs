using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy.Implementacion
{
    public class InfoPedido : IInfoPedido
    {

        string IInfoPedido.ValidarAccesoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor)
        {
            return "X";
        }

        string IInfoPedido.ObtenerInfoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor)
        {
            return "Información pedido: ";
        }


    }
}
