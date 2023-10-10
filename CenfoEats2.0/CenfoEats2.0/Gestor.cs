using CenfoEats2._0.PMetodoFabrica.Creador;
using CenfoEats2._0.PMetodoFabrica.CreadorConcreto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0
{
    public class Gestor
    {
        private static I_Creador_Usuarios Ufabrica;

        public Gestor()
        {
            Ufabrica = new Creador_Usuarios();
        }
        public void nuevoUsuario(string nombre, string correo_electronico, string telefono, string tipo, string contrasenna)
        {
            if (tipo == "Cliente")
            {
                Cliente objCliente = new Cliente(nombre, correo_electronico, telefono, contrasenna);
               Console.WriteLine(objCliente.ToString());
            }
            if (tipo == "Repartidor")
            {
                Repartidor objRepartidor = new Repartidor(nombre, correo_electronico, telefono, contrasenna);
                Console.WriteLine(objRepartidor.ToString());
            }
        }
    }
}

