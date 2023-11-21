using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy.Implementacion
{
    public class InfoPedido : IInfoPedido
    {
        String ObtenerPedido(int idRepartidor, int idPedido); //REFERENCIA AL PEDIDO
        {
            // Lógica para obtener el pedido desde la base de datos
            // Puedes utilizar Entity Framework u otro mecanismo de acceso a datos
            // y devolver un objeto Pedido
        }
    }
}