using CenfoEats2._0.PFabricaAbstracta.FabricaAbstracta;
using CenfoEats2._0.PFabricaAbstracta.FabricaConcreta;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Creador;
using CenfoEats2._0.PMetodoFabrica.CreadorConcreto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.PPrototipo.Menu;
using CenfoEats2._0.PProxy;
using CenfoEats2._0.PSingleton.CRUD;
using CenfoEats2._0.PSingleton.DAOs;
using CenfoEats2._0.PSingleton.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CenfoEats2._0
{
    public class Gestor
    {
        private static I_Creador_Usuarios Ufabrica;
        private IFabTipoPedido fabricaTipoPedido;
        private GestorProxy gestorProxy;


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
            else if (tipo == "Repartidor")
            {
                Repartidor objRepartidor = new Repartidor(nombre, correo_electronico, telefono, contrasenna);
                Console.WriteLine(objRepartidor.ToString());
                crudFactory.Create(objRepartidor);
            }
        }



        // PROXY

        public string ObtenerInfoProxy(int idPedido, int idCliente, int idRepartidor)
        {
            return gestorProxy.InformacionTotal(idPedido, idCliente, idRepartidor);
        }

        public bool validacionIdRequeridos(object idClient, object idRepartidor, object idOrder)
        {
            if (idOrder != null && (idClient != null || idClient != null))
            {
                return true;
            }
            return false;
        }

        //REALIZAR PEDIDO


        public int SeleccionarIdRepartidorAleatorio()
        {
            var userMapper = new UserMapper();  // Instancia del mapper
            var dao = SqlDAO.GetInstance();

            // Obtener el statement para seleccionar un repartidor aleatorio
            var sqlOperation = userMapper.GetRandomRepartidorStatement();

            // Ejecutar el procedimiento almacenado para obtener un repartidor aleatorio
            var repartidorId = dao.ExecuteQueryProcedure(sqlOperation)
                .FirstOrDefault(); // Tomar el primer resultado (si hay alguno)

            if (repartidorId != null)
            {
                return Convert.ToInt32(repartidorId["ID_USER"]);
            }
            else
            {
                // Manejar la situación en la que no hay repartidores disponibles
                return -1;
            }
        }

        public string ObtenerNombreRepartidorAleatorio()
        {
            var userMapper = new UserMapper();
            var dao = SqlDAO.GetInstance();

            int repartidorId = SeleccionarIdRepartidorAleatorio();

            if (repartidorId != -1)
            {
                var sqlOperation = userMapper.GetRetrieveByIdStatement(new UsuarioDB { id = repartidorId });

                var repartidor = dao.ExecuteQueryProcedure(sqlOperation)
                    .FirstOrDefault();

                if (repartidor != null)
                {
                    return repartidor["NAME"].ToString();
                }
                else
                {

                    return "Nombre no disponible";
                }
            }
            else
            {

                return "Sin repartidor disponible";
            }
        }

        public string CrearPedido(string tipoPedido, int idCliente, string address)
        {
            // Utiliza la fábrica abstracta para obtener una fábrica concreta según el tipo especificado
            IFabTipoPedido fabricaConcreta = ObtenerFabricaConcreta(tipoPedido);

            // Utiliza la fábrica concreta para crear un pedido según el tipo especificado
            Pedido pedido = fabricaConcreta.crearPedido();

            // Configura el pedido con la información específica según el tipo
            pedido.idClient = idCliente;
            pedido.idRestaurant = 1;
            pedido.date = DateTime.Now;
            pedido.status = "Pendiente";


            if (tipoPedido == "Domicilio")
            {
                //pedido.iddriver = seleccionaridrepartidoraleatorio(); // marca error pero no es error 
                //pedido.address = address;
                pedido.pickUp = 1;
            }
            else if (tipoPedido == "RecogerSitio")
            {
                pedido.pickUp = 0;
            }
            return pedido.ToString();
            //GuardarPedidoEnBD(pedido);

        }

        private IFabTipoPedido ObtenerFabricaConcreta(string tipoPedido)
        {
            // Esto es para obtener la fábrica concreta según el tipo de pedido
            switch (tipoPedido)
            {
                case "Domicilio":
                    return new FDomicilio();
                case "RecogerSitio":
                    return new FRecogerSitio();
                default:
                    throw new ArgumentException("Tipo de pedido no válido", nameof(tipoPedido));
            }
        }

        private void GuardarPedidoEnBD(Pedido pedido)
        {
            var orderCrudFactory = new OrderCrudFactory();


            orderCrudFactory.Create(pedido);
        }



    }
}