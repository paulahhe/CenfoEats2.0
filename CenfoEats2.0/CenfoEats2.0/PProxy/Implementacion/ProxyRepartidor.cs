using System;
using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PProxy.Implementacion;
using CenfoEats2._0.PProxy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Producto;

namespace CenfoEats2._0.PProxy
{
    public class ProxyRepartidor : IInfoPedido
    {

        private bool _LoginExitoso = false;


        bool validacionID(ADomicilio pedido, int idCliente, int idRepartidor) //PROBABLEMENTE VA EN GESTOR
        {
            bool tieneAcceso = false;


            if (pedido.GetIdClient() == idCliente && pedido.GetIdDriver() == idRepartidor)
            {
                tieneAcceso = true;
            }


            return tieneAcceso;
        }
        public string ValidarAccesoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor)
        {
            _LoginExitoso = validacionID(pedido, cliente.id, repartidor.id);

            if (!_LoginExitoso)
            {
                return "No tiene acceso a la información del pedido";
            }
            return ObtenerInfoPedido(pedido, cliente, repartidor);
        }


        public string ObtenerInfoPedido(ADomicilio pedido, Usuario cliente, Usuario repartidor)
        {
            string mensaje = "Información del pedido: <br>" +
            "Restaurante: " + pedido.idRestaurant + " colones. <br>" +
            "Dirección de Entrega: " + pedido.address + ".<br>" +
            "Número de telefono del cliente: " + cliente.telefono + ". <br>" +
            "Nombre del repartidor: " + repartidor.nombre + ". <br>" +
            "Número de telefono del repartidor: " + repartidor.telefono + ".";

            return mensaje;

        }
    }


}