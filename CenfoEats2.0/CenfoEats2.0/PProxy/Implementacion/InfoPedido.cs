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

        string IInfoPedido.ValidarAccesoPedido(int idPedido, int idCliente, int idRepartidor)
        {
            return "X";
        }

        string IInfoPedido.ObtenerInfoPedido(int idPedido, int idUsuario, int idRepartidor)
        {
            return "Información pedido: ";
        }


    }
