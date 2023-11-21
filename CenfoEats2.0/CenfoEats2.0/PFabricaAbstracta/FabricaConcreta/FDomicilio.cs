﻿using CenfoEats2._0.PFabricaAbstracta.FabricaAbstracta;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.FabricaConcreta
{
    public class FDomicilio : IFabTipoPedido
    {
        public Pedido crearPedido()
        {
            Pedido miPedido = new ADomicilio();
            return miPedido;
        }
    }

}
