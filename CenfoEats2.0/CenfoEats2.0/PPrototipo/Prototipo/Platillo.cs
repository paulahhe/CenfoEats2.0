using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PPrototipo.iPrototipo;


namespace CenfoEats2._0.PPrototipo.Menu
{
    public class Platillo : iPlatillo
    {
       
        public Platillo(string nombre, double precio, string descripcion)
        {
            this.nombre = nombre;
            this.precio = (decimal)precio;
            this.descripcion = descripcion;
        }

        override
        public iPlatillo cloneP()
        {
            return new Platillo(nombre, (double)precio, descripcion);
        }
    }
}