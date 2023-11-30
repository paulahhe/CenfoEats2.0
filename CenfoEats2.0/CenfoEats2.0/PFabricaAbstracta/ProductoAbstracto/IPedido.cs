using CenfoEats2._0.PEstado.Abstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto
{
    public interface IPedido
    {

        int GetIdOrder();
        int GetIdClient();
        int GetIdRestaurant();
        string GetStatus();
        DateTime GetDate();
        void CambiarEstado(string nuevoEstado);
    }
}
