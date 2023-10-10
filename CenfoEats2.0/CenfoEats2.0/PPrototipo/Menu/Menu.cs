using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PPrototipo.Menu
{
    public abstract class Menu
    {
        public int cantidadPlatillos { get; set; }

        public Menu(int cantidadPlatillos)
        {
            this.cantidadPlatillos = cantidadPlatillos;
        }
    }
}