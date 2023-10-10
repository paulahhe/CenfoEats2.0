using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PPrototipo.Menu
{
    public class MenuMcDonalds : Menu
    {
        private string platillo1;
        private int precioPlatillo;

        public MenuMcDonalds(int cantidadPlatillos, string Platillo1, int PrecioPlatillo) : base(cantidadPlatillos)
        {
            platillo1 = Platillo1;
            precioPlatillo = PrecioPlatillo;
        }
    }
}

