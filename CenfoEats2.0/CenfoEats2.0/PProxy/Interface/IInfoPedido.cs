using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Producto;

namespace CenfoEats2._0.PDecorador
{
    public interface IInfoPedido
    {
        string ValidarAccesoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor);

        string ObtenerInfoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor);

    }
}