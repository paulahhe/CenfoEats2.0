using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class RecogerSitio : IPedido
    {
        public int idOrder { get; set; }
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }


        public RecogerSitio()
        {
        }

        public int GetIdOrder()
        {
            return idOrder;
        }

        public int GetIdClient()
        {
            return idClient;
        }

        public int GetIdRestaurant()
        {
            return idRestaurant;
        }

        public string GetStatus()
        {
            return status;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public int GetIdDriver()
        {
            throw new NotImplementedException();
        }
    }
}

