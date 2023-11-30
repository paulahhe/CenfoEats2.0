using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PPrototipo.iPrototipo;


namespace CenfoEats2._0.PPrototipo.Prototipo
{
    public class Platillo : iPlatillo
    {

        public Platillo(string nombre, double precio, string descripcion)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getDescripcion()
        {
            return descripcion;
        }


        public double getPrecio()
        {
            return precio;
        }

        override
        public iPlatillo cloneP()
        {
            return new Platillo(nombre, (double)precio, descripcion);
        }


    }
}