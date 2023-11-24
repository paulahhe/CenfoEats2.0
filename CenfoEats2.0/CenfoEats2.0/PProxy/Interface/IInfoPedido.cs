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
        string ValidarAccesoPedido(int idPedido, int idUsuario);

        string ObtenerInfoPedido(int idRepartidor, int idPedido); //REFERENCIA AL PEDIDOsdsdsds

    }
}

