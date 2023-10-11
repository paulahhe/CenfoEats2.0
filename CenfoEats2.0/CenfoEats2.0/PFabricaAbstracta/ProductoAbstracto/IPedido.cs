using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto
{
    public interface IPedido
    {

        int idOrder { get; set; }
        int idClient { get; set; }
        int idDriver { get; set; }
        int idRestaurant { get; set; }
        string status { get; set; }
        DateTime date { get; set; }

    }
}
