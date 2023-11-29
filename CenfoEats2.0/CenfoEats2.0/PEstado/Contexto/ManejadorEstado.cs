using CenfoEats2._0.PEstado.Abstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PEstado.Contexto
{
    public class ManejadorEstado
    {
        protected IEstadoPedido estadoPedido;
        public ManejadorEstado(IEstadoPedido estadoInicial)
        {
            estadoPedido = estadoInicial;
        }
        public void setEstadoPedido (IEstadoPedido estadoPedido)
        { 
            this.estadoPedido = estadoPedido;
        }
        public String getInfo()
        {
            return this.estadoPedido.obtenerEstado();
        }
    }
}
