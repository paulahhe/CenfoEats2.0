using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PFabricaAbstracta.ProductoConcreto;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.PSingleton.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PProxy
{
    public class ProxyRepartidor : IInfoPedido
    {

       
        private IInfoPedido infoPedido;
        private Usuario usuario;
        private Repartidor reparitdor;
        private ADomicilio pedido;

        private String ubicacionEntrega;
        private String telefonoCliente;
        private Cliente cliente;
        private int idCliente;


        public Usuario ObtenerInformacionCliente(int idCliente)
        {
            // Crear instancia del CRUD para usuarios
            var userCrud = new UserCrudFactory();

            // Obtener la lista de todos los usuarios
            var usuarios = userCrud.RetrieveAll<UsuarioDB>();

            // Buscar el usuario con el idCliente proporcionado
            var cliente = usuarios.FirstOrDefault(u => u.id == idCliente);

            // Verificar si se encontró el cliente
            if (cliente != null)
            {
                // Crear una instancia de Usuario a partir de la información obtenida
                var clienteOrden = new Cliente
                {
                    nombre = cliente.nombre,
                    correo_electronico = cliente.correo_electronico,
                    telefono = cliente.telefono,
                    tipo = cliente.tipo,
                    contrasenna = cliente.contrasenna
                };

                return clienteOrden;
            }
            else
            {
                // Manejar el caso en el que no se encuentre el cliente
                throw new Exception("Cliente no encontrado");
            }
        }


        public Usuario ObtenerInformacionRepartidor(int idRepartidor)
        {
            // Crear instancia del CRUD para usuarios
            var userCrud = new UserCrudFactory();

            // Obtener la lista de todos los usuarios
            var usuarios = userCrud.RetrieveAll<UsuarioDB>();

            // Buscar el usuario con el idRepartidor proporcionado
            var cliente = usuarios.FirstOrDefault(u => u.id == idCliente);

            // Verificar si se encontró el repartidor
            if (cliente != null)
            {
                // Crear una instancia de Usuario a partir de la información obtenida
                var clienteOrden = new Cliente
                {
                    nombre = cliente.nombre,
                    correo_electronico = cliente.correo_electronico,
                    telefono = cliente.telefono,
                    tipo = cliente.tipo,
                    contrasenna = cliente.contrasenna
                };

                return clienteOrden;
            }
            else
            {
                // Manejar el caso en el que no se encuentre el cliente
                throw new Exception("Cliente no encontrado");
            }
        }



        public void ObtenerInfoPedido(int idPedido)

           
        {
            // Lógica para validar el acceso basado en el tipo de usuario
            if (usuario.tipo == "Repartidor")
            {
                if (usuario.id == pedido.GetIdDriver())
                {
                    ubicacionEntrega = pedido.ubicacion;
                    telefonoCliente = ObtenerInformacionCliente(pedido.GetIdClient()).telefono;

                    
                }
              
            }
            else
            {
                // Manejar el caso en el que un cliente u otro tipo de usuario intenta acceder
                // Puedes lanzar una excepción o devolver un objeto Pedido vacío, dependiendo de tus requerimientos
                throw new UnauthorizedAccessException("Acceso no autorizado");
            }
        }

        public string ObtenerPedido(int idRepartidor, int idPedido)
        {
            throw new NotImplementedException();
        }

        public void cargarInformacionPedido()
        {
            throw new NotImplementedException();
        }
    }
}