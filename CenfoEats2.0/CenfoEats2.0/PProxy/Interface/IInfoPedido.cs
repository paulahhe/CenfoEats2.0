using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;

namespace CenfoEats2._0.PDecorador
{
    public interface IInfoPedido
    {
       String ObtenerPedido(int idRepartidor, int idPedido); //REFERENCIA AL PEDIDO


        void cargarInformacionPedido();

    }
}

