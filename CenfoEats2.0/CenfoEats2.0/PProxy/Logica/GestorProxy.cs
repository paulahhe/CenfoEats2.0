using CenfoEats2._0.PDecorador;
using CenfoEats2._0.PDecorador.Componente;
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
    public class GestorProxy
    {
        private Usuario usuario;
        private Repartidor repartidor;
        private ADomicilio pedido;
        private Cliente cliente;
        private int idCliente;
        private int idRepartidor;
        private String infoCliente


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
            var repartidor = usuarios.FirstOrDefault(u => u.id == idrepartidor);

            // Verificar si se encontró el repartidor
            if (repartidor != null)
            {
                // Crear una instancia de Usuario a partir de la información obtenida
                var repartidorOrden = new repartidor
                {
                    nombre = repartidor.nombre,
                    correo_electronico = repartidor.correo_electronico,
                    telefono = repartidor.telefono,
                    tipo = repartidor.tipo,
                    contrasenna = repartidor.contrasenna
                };

                return repartidorOrden;
            }
            else
            {
                // Manejar el caso en el que no se encuentre el repartidor
                throw new Exception("Repartidor no encontrado");
            }
        }

       



}





}
