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




        string IInfoPedido.ObtenerPedido(int idRepartidor, int idPedido)
        {
            throw new NotImplementedException();
        }

        public string ValidarAccesoPedido(int idPedido, int idUsuario) //Usuario y pedi   
        {
            bool tieneAccseso = false;
            setTipo("Ninguno");


            // Lógica para validar el acceso basado en el tipo de usuario
            if (usuario.tipo == "Repartidor")
                setTipo("Repartidor");
            {
                tieneAccseso = true;

            }
            else if (usuario.tipo == "Cliente")
            {
                setTipo("Cliente");
                tieneAccseso = true;


            }

            return "Acceso no autorizado";

        }

        public static String getTipo()
        {
            return usuario.tipo;
        }

        private static void setTipo(string pTipo)
        {
            usuario.tipo = pTipo;
        }

        public void cargarInformacionPedido()
        {
            throw new NotImplementedException();
        }

       
    }
}