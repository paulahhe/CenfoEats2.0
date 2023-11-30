using CenfoEats2._0.PDecorador.Decorador;
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
        private List<Pedido> listPedidos;
        private List<Platillo> listPlatillos;
        private List<IngredienteExtra> listIngredientesExtras;

        private Platillo bigWopper;
        private Platillo tacosPatron;
        private Platillo ensaladaPatrones;

        private IngredienteExtra cebollaExtra;
        private IngredienteExtra tomateExtra;
        private IngredienteExtra quesoExtra;

        public Gestor()
        {
            Ufabrica = new Creador_Usuarios();

   
            bigWopper = new Platillo("BigWopper", 4500, "Hamburguesa gigante con carne y queso");
            tacosPatron = new Platillo("Tacos al Patrón", 5000, "Tacos auténticos con carne y salsa especial");
            ensaladaPatrones = new Platillo("Ensalada de patrones", 3000, "Ensalada fresca con ingredientes exclusivos");


            cebollaExtra = new IngredienteExtra("Cebolla Extra", 500);
            tomateExtra = new IngredienteExtra("Tomate Extra", 700);
            quesoExtra = new IngredienteExtra("Queso Extra", 800);

            listPlatillos = new List<Platillo>();
            listIngredientesExtras = new List<IngredienteExtra>();

            listPlatillos.Add(bigWopper);
            listPlatillos.Add(tacosPatron);
            listPlatillos.Add(ensaladaPatrones);

            listIngredientesExtras.Add(cebollaExtra);
            listIngredientesExtras.Add(tomateExtra);
            listIngredientesExtras.Add(quesoExtra);
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

        public Platillo ObtenerPlatilloPorNombre(string nombrePlatillo)
        {
            return listPlatillos.FirstOrDefault(platillo => platillo.getNombre().Equals(nombrePlatillo, StringComparison.OrdinalIgnoreCase));
        }

        public IngredienteExtra ObtenerIngredienteExtraPorNombre(string nombreIngredienteExtra)
        {
            return listIngredientesExtras.FirstOrDefault(ingredienteExtra => ingredienteExtra.getNombre().Equals(nombreIngredienteExtra, StringComparison.OrdinalIgnoreCase));
        }

        public string CrearPedido(string tipoPedido, int idCliente, string address, string platillo /*, string ingredienteExtra*/)
        {
            IFabTipoPedido fabricaConcreta = ObtenerFabricaConcreta(tipoPedido);

            Pedido pedido = fabricaConcreta.crearPedido();

            Platillo objPlatillo = ObtenerPlatilloPorNombre(platillo);


            //if (ingredienteExtra != null)
            //{

            //    //IngredienteExtra objIngredienteExtra = ObtenerIngredienteExtraPorNombre(ingredienteExtra);


            //    //IngredienteExtra decorador = new IngredienteExtra(objPlatillo, objIngredienteExtra.getNombre(), objIngredienteExtra.getPrecio());
            //    //productosDecorados.Add(decorador);
            //    //objPlatillo = decorador; // Actualizar la referencia al platillo decorado
            //}

            // Configura el pedido con la información específica según el tipo
            pedido.idClient = idCliente;
            pedido.idRestaurant = 1;
            pedido.date = DateTime.Now;
            pedido.status = "Pendiente";
            pedido.platillo = objPlatillo;


            var infoPedido = "Información del Pedido: \r\n" +
                "Restaurante: " + pedido.idRestaurant + ".\r\n" +
                "Cliente: " + pedido.idClient + ".\r\n" +
                "Fecha: " + pedido.date.ToString("yyyy-MM-dd HH:mm:ss") + ".\r\n" +
                "Estado: " + pedido.status + ".\r\n" +
                "Platillo: " + pedido.platillo.nombre + ".\r\n" +
                "Descripción del platillo: " + pedido.platillo.descripcion + ".\r\n" +
                "Precio: " + pedido.platillo.precio + " colones.\r\n";


            if (tipoPedido == "Domicilio")
            {
                
                pedido.idDriver = SeleccionarIdRepartidorAleatorio(); // marca error pero no es error 
                pedido.address = address;
                pedido.pickUp = 1;
                //nombreRepartidor = ObtenerNombreRepartidorAleatorio();

                infoPedido += "Repartidor: " + pedido.idDriver + ".\r\n" +
                  "Dirección de Entrega: " + pedido.address + ".\r\n";
            }
            else if (tipoPedido == "RecogerSitio")
            {
                pedido.idDriver = 0; 
                pedido.address = null;
                pedido.pickUp = 0;
            }


            return infoPedido;
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