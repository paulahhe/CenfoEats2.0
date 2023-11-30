using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PDecorador.Componente;
using CenfoEats2._0.PPrototipo.Prototipo;

namespace CenfoEats2._0.PDecorador.Decorador
{
    public abstract class IngredienteExtraDecorador : Producto
    {
        protected Producto producto;


        public Producto getProducto()
        {
            return producto;
        }


    }
}
