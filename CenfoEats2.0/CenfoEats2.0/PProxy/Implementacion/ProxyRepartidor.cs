using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.PSingleton.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy
{
    public class ProxyRepartidor : IInfoPedido
    {
        private String ubicacionEntrega; //Repartidor
        private String telefonoCliente; //Repartidor
        private String nombreRepartidor; //Cliente
        private String telefonoRepartdor; //Cliente




        //string IInfoPedido.ObtenerPedido(int idRepartidor, int idPedido)
        //{
        //    throw new NotImplementedException();
        //}

        public string ObtenerPedido(int idPedido, int idUsuario, id) //Usuario y pedido

           
        {
            // Lógica para validar el acceso basado en el tipo de usuario
            if (usuario.tipo == "Repartidor")
            {
                if (usuario.id == pedido.GetIdDriver())
                {
                    ubicacionEntrega = pedido.ubicacion;
                    telefonoCliente = ObtenerInformacionCliente(pedido.GetIdClient()).telefono;

                    return "La ubicación del pedido es: " + ubicacionEntrega + " Y el número del cliente es: " + telefonoCliente;
                }
              
            }
            else if (usuario.tipo == "Cliente")
            {
                if (usuario.id == pedido.GetIdCliente())
                {
                    nombreRepartidor = ObtenerInformacionRepartidor(pedido.GetIdClient()).telefono;
                    telefonoRepartdor = ObtenerInformacionCliente(pedido.GetIdClient()).telefono;

                    return "La ubicación del pedido es: " + ubicacionEntrega + " Y el número del cliente es: " + telefonoCliente;
                }
                {


            }

            return "Acceso no autorizado";
          
        } 

        public void cargarInformacionPedido()
        {
            throw new NotImplementedException();
        }

       
    }
}