using CenfoEats2._0.PFabricaAbstracta.FabricaAbstracta;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PMetodoFabrica.Creador;
using CenfoEats2._0.PMetodoFabrica.CreadorConcreto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.PSingleton.CRUD;
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
            var crudFactory = new UserCrudFactory();
            if (tipo == "Cliente")
            {
               Cliente objCliente = new Cliente(nombre, correo_electronico, telefono, contrasenna);
               Console.WriteLine(objCliente.ToString());
                crudFactory.Create(objCliente);
            }
            if (tipo == "Repartidor")
            {
                Repartidor objRepartidor = new Repartidor(nombre, correo_electronico, telefono, contrasenna);
                Console.WriteLine(objRepartidor.ToString());
                crudFactory.Create(objRepartidor);
            }
        }
        private IFabTipoPedido fabricaTipoPedido; // La fábrica abstracta

        public Gestor(IFabTipoPedido fabrica)
        {
            fabricaTipoPedido = fabrica;
        }

        public void CrearPedido()
        {
            // Se utiliza la fábrica abstracta para crear un pedido
            IPedido objpedido = fabricaTipoPedido.crearPedido();

            // Se realiza acciones específicas del pedido
            int idOrder = objpedido.idOrder;
            int idClient = objpedido.idClient;
            int idDriver = objpedido.idDriver;
            int idRestaurant = objpedido.idRestaurant;
            string status = objpedido.status;
            DateTime date = objpedido.date;

        }
    }
}

