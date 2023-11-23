using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CenfoEats2._0.PEstado.Abstracto
{
    public interface IEstadoPedido
    {
        String obtenerEstado();
        void verificarEstadoD(ADomicilio pedido);
        void verificarEstadoR(RecogerSitio pedido);
    }
}
