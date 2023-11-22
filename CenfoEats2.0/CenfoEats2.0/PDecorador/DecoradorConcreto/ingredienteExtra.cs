using CenfoEats2._0.PDecorador.Componente;
using CenfoEats2._0.PPrototipo.Prototipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PDecorador.Decorador
{
    public class ingredienteExtra : IngredienteExtraDecorador
    {
        private string nombre;
        private double precio;


        public ingredienteExtra(Producto pProducto)
        {
            this.producto = pProducto;
        }

        public ingredienteExtra(Restaurant pRestaurant)
        {
            this.restaurante = pRestaurant;
        }

        override
         public string getNombre()
        {
            return this.producto.getNombre() + "con" + nombre;
        }

        override
         public string getDescripcion()
        {
            return this.producto.getDescripcion() + "con" + nombre;
        }

        override
         public double getPrecio()
        {
            return this.producto.getPrecio() + precio;
        }

        public override string getRestaurant()
        {
            throw new NotImplementedException();
        }
    }
}
