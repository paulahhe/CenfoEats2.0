using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PPrototipo.Menu;
using CenfoEats2._0.PPrototipo.iPrototipo;
using CenfoEats2._0.PPrototipo.Prototipo;

namespace CenfoEats2._0.PDecorador.Componente
{
    public abstract class Producto
    {
        public Platillo platillo;
        public Restaurant restaurante;

        public abstract string getNombre();

        public abstract string getDescripcion();

        public abstract double getPrecio();

        public abstract string getNombreRestaurante();
    }
}
