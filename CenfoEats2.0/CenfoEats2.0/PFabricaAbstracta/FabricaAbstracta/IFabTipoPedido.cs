using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.FabricaAbstracta.Producto_Abstracto;

namespace Models.FabricaAbstracta.Fabrica_Abstracta
{
    public interface IFabTipoPedido
    {
       IPedido crearPedido();
    }
}