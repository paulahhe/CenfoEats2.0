using CenfoEats2._0.PEstado.Abstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PEstado.Contexto
{
    public abstract class ManejadorEstado
    {
        protected IEstadoPedido estadoPedido; 
        public ManejadorEstado() {
            estadoPedido = new Concreto.EstadoPendiente();
        }

        public void setEstadoPedido (IEstadoPedido estadoPedido)
        { 
            this.estadoPedido = estadoPedido;
        }
        public void verificarEstadoDomicilio(ADomicilio status)
        {
            estadoPedido.verificarEstadoD(status);
        }

        public void verificarEstadoSitio (RecogerSitio status)
        {
            estadoPedido.verificarEstadoR(status);
        }

        public String getInfo()
        {
            return this.estadoPedido.obtenerEstado();
        }
    }
}
