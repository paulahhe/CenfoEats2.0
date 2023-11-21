﻿using CenfoEats2._0.PMetodoFabrica.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PMetodoFabrica.ProductoConcreto
{
    class Repartidor : Usuario
    {
        public Repartidor(string nombre, string correo_electronico, string telefono, string contrasenna)
        {
            this.nombre = nombre;
            this.correo_electronico = correo_electronico;
            this.telefono = telefono;
            this.tipo = "Repartidor";
            this.contrasenna = contrasenna;

        }
    }
}
