using CenfoEats2._0.PEstado.Abstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PEstado.Concreto
{
    public class EstadoEntregado : IEstadoPedido
    {
        public string obtenerEstado()
        {
            return "Entregado";
        }

        public void verificarEstadoD(ADomicilio pedido)
        {
            throw new NotImplementedException();
        }

        public void verificarEstadoR(RecogerSitio pedido)
        {
            throw new NotImplementedException();
        }
    }
}
