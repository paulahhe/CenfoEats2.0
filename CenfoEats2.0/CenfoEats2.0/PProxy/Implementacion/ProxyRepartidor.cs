using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy
{
    public class RepartidorReal : IInfoPedido
    {

        public void obtenerInformacionCliente(String idPedido);
        public void realizarEntrega(String idPedido);

        private readonly IInfoPedido infoPedido;
        private readonly string tipoUsuario; // Puedes obtener esto de la autenticación del usuario

        public ProxyPedidoRepartidor(IInfoPedido infoPedido, string tipoUsuario)
        {
            this.infoPedido = infoPedido;
            this.tipoUsuario = tipoUsuario;
        }

        public Pedido ObtenerPedido(int idPedido)
        {
            // Lógica para validar el acceso basado en el tipo de usuario
            if (tipoUsuario.ToLower() == "repartidor")
            {
                // Lógica adicional para validar si el repartidor tiene acceso al pedido
                // Puedes verificar si el repartidor está relacionado con el pedido en la base de datos
                // Si es válido, puedes llamar al servicio real para obtener el pedido
                return pedidoService.ObtenerPedido(idPedido);
            }
            else
            {
                // Manejar el caso en el que un cliente u otro tipo de usuario intenta acceder
                // Puedes lanzar una excepción o devolver un objeto Pedido vacío, dependiendo de tus requerimientos
                throw new UnauthorizedAccessException("Acceso no autorizado");
            }
        }

    }
}