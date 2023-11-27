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
        private String ubicacionEntrega; //Cliente
        private String telefonoCliente; //Cliente
        private String nombreRepartidor; //Repartidor
        private String telefonoRepartdor; //Repartidor

        private InfoPedido _InfoPedido = new InfoPedido();
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
        public string ValidarAccesoPedido(int idPedido, int idCliente, int idRepartidor)
        {
            _LoginExitoso = validacionID(idPedido, idCliente, idRepartidor);

            if (!_LoginExitoso)
            {
                return "No tiene acceso a la información del pedido";
            }
            return ObtenerInfoPedido();
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








        //public string ValidarAccesoPedido(int idPedido, int idUsuario) //Usuario y pedi   
        //{
        //    bool tieneAccseso = false;
        //    setTipo("Ninguno");


        //    // Lógica para validar el acceso basado en el tipo de usuario
        //    if (usuario.tipo == "Repartidor")
        //        setTipo("Repartidor");
        //    {
        //        tieneAccseso = true;

        //    }
        //    else if (usuario.tipo == "Cliente")
        //    {
        //        setTipo("Cliente");
        //        tieneAccseso = true;


        //    }

        //    return "Acceso no autorizado";

        //}

        //public static String getTipo()
        //{
        //    return usuario.tipo;
        //}

        //private static void setTipo(string pTipo)
        //{
        //    usuario.tipo = pTipo;
        //}

        //public void cargarInformacionPedido()
        //{
        //    throw new NotImplementedException();
        //}


 }
