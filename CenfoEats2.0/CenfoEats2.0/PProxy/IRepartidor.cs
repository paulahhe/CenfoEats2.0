﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PDecorador
{
    public interface IRepartidor
    {

        void obtenerInformacionCliente(String idPedido);
        void realizarEntrega(String idPedido);
    }
}
