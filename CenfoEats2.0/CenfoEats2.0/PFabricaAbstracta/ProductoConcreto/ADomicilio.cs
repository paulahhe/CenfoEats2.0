using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class ADomicilio : Pedido
    {
        public int idDriver { get; set; }

        public string address { get; set; }


        public ADomicilio()
        {
            idDriver = -1;
            address = null;
        }

        public ADomicilio(int pId, string pAddress)
        {
            idDriver = pId;
            address = pAddress;
        }

        public int GetIdDriver()
        {
            return idDriver;
        }

        public string GetAddress()
        {
            return address;
        }

    }
}
