using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class ADomicilio : Pedido
    {
        public int idDriver { get; set; }


        public ADomicilio()
        {
        }

        public int GetIdDriver()
        {
            return idDriver;
        }

    }
}
