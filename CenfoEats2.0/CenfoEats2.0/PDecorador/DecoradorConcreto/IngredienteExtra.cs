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
    public class IngredienteExtra : IngredienteExtraDecorador
    {
        private string nombre;
        private double precio;




        public IngredienteExtra(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public IngredienteExtra(Producto pProducto, string nombre, double precio)
        {
            this.producto = pProducto;
            this.nombre = nombre;
            this.precio = precio;      
        }

        public IngredienteExtra(Platillo pProducto, string nombre, double precio)
        {
            this.producto.platillo = pProducto;
            this.nombre = nombre;
            this.precio = precio;
        }



        override
         public string getNombre()
        {
            return this.producto.platillo.getNombre() + "con" + nombre;
        }

        override
         public string getDescripcion()
        {
            return this.producto.platillo.getDescripcion() + "con" + nombre;
        }

        override
         public double getPrecio()
        {
            return this.producto.platillo.getPrecio() + precio;
        }

        public override string getNombreRestaurante()
        {
            throw new NotImplementedException();
        }
    }
}
