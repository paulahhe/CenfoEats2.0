using Models.FabricaAbstracta.Fabrica_Abstracta;
using Models.FabricaAbstracta.Producto_Abstracto;
using Models.FabricaAbstracta.Producto_Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FabricaAbstracta.Fabrica_Concreta
{
    public class FDomicilio : IFabTipoPedido
    {
        public IPedido crearPedido()
        {
            IPedido miPedido = new ADomicilio();

            return miPedido;
        }
    }

}