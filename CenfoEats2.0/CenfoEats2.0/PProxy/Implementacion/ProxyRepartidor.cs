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

       
        private IInfoPedido infoPedido;
        private Usuario usuario;
        private Repartidor reparitdor;
        private ADomicilio pedido;

        private String ubicacionEntrega;
        private String telefonoCliente;
        private Cliente cliente;
        private int idCliente;


        public string ObtenerPedido(int idRepartidor, int idPedido)
        {
            throw new NotImplementedException();
        }

        public void cargarInformacionPedido()
        {
            throw new NotImplementedException();
        }
    }
}