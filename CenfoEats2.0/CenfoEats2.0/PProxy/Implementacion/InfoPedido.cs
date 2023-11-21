using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PDecorador
{
    public interface IInfoPedido
    {
        Pedido ObtenerPedido(int idPedido); //REFERENCIA AL PEDIDO

        void obtenerInformacionCliente();
        void realizarEntrega();

    }
}