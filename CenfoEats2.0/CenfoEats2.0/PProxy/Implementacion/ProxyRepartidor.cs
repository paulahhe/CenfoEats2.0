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
        private int _InfoPrivada = 5;

        private List<ADomicilio> listaPedidos = new List<ADomicilio>();
        ADomicilioDao domicilioDao = new ADomicilioDao();

        ADomicilio obtenerPedido(int id) { //PROBABLEMENTE VA EN GESTOR
            listaPedidos = domicilioDao.listarPedidosDomicilio();

            foreach (ADomicilio objPedido in listaPedidos)
            {
                if (objPedido.GetIdOrder() == id)
                {
                    return objPedido;
                }
            }
            return null;
          }

        bool validacionID(int idPedido, int idCliente, int idRepartidor) //PROBABLEMENTE VA EN GESTOR
        {
            bool tieneAcceso = false;

            ADomicilio pedido = obtenerPedido(idPedido);

            if (pedido.GetPickUp() == 1)
            {
                if (pedido.GetIdClient() == idCliente && pedido.GetIdDriver() == idRepartidor)
                {
                    tieneAcceso = true;
                }
            }

            return tieneAcceso;
        }
        public string ValidarAccesoPedido(int idPedido, int idCliente, int idRepartidor)
        {
            _LoginExitoso = validacionID( idPedido,  idCliente,  idRepartidor);

            if(!_LoginExitoso)
            {
                return "No tiene acceso a la información del pedido";
            }
            return "Credenciales aceptadas para la información del pedido";
        }
        public string ObtenerInfoPedido(int idPedido, int idUsuario, int idRepartidor)
        {
            if (_LoginExitoso)
            {
                string mensajeAceptado = "Ingreso aceptado";
            } else
            {
                return "Credenciales no aceptadas";
            }
            return null;
            //AQUI SE TIENE QUE PONER LA INFO DEL PEDIDO
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
}