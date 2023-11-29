using CenfoEats2._0.PDecorador.Componente;
using CenfoEats2._0.PPrototipo.Menu;
using CenfoEats2._0.PPrototipo.Prototipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PDecorador.ComponeneteConcreto
{
    public class ProductoConcreto : Producto
    {

        public ProductoConcreto(Platillo platillo, Restaurant restaurante)
        {
            this.platillo = platillo;
            this.restaurante = restaurante;
        }


        public override string getNombre()
        {
            return platillo.nombre;
        }


        public override string getDescripcion()
        {
            return platillo.descripcion;
        }



        public override double getPrecio()
        {
            return (double)platillo.precio;
        }

        public override string getNombreRestaurante()
        {
            return restaurante.name;
        }
    }
}
