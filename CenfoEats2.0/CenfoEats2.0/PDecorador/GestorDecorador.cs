using CenfoEats2._0.PDecorador.ComponeneteConcreto;
using CenfoEats2._0.PDecorador.Componente;
using CenfoEats2._0.PDecorador.Decorador;
using CenfoEats2._0.PPrototipo.Prototipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PDecorador
{
    public class GestorDecorador
    {
        private List<Producto> listaDeProductos { get; set; }

        public GestorDecorador()
        {
            setListaDeProductos(new List<Producto>());
        }

        public void nuevoProducto(Platillo platillo, Restaurant restaurante)
        {
            Producto p = new ProductoConcreto(platillo, restaurante);
            getListaDeProductos().Add(p);
        }

        public void decorarProducto(int pIdProducto)
        {
            Producto p = this.getProducto(pIdProducto);

            replaceProductoArray(pIdProducto, new IngredienteExtra(p));



        }

        public void quitarDecoracionProducto(int pIdProducto)
        {
            IngredienteExtraDecorador pDecorada = (IngredienteExtraDecorador)this.getProducto(pIdProducto);
            Producto productoL = pDecorada.getProducto();
            replaceProductoArray(pIdProducto, productoL);
        }

        public String printProducto(int pId)
        {
            Producto pPA = this.getProducto(pId);

            return pPA.getNombre() + "\n"
                + pPA.getPrecio() + " colones \n"
                + "Descripción: " + pPA.getDescripcion();
        }

        public Producto getProducto(int pId)
        {
            return listaDeProductos[pId];
        }

        public List<Producto> getListaDeProductos()
        {
            return listaDeProductos;
        }

        public void setListaDeProductos(List<Producto> listaProductos)
        {
            this.listaDeProductos = listaProductos;
        }

        public void replaceProductoArray(int pId, IngredienteExtraDecorador pP)
        {
            this.listaDeProductos[pId] = pP;
        }

        public void replaceProductoArray(int pId, Producto pP)
        {
            this.listaDeProductos[pId] = pP;
        }
    }
}