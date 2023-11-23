using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Models.FabricaAbstracta.Producto_Abstracto
{
    public interface IPedido
    {

       int GetIdOrder();
       int GetIdClient();
       int GetIdDriver(); 
       int GetIdRestaurant();
       string GetStatus();
       DateTime GetDate();
       string GetInfoPedido();

    }
}