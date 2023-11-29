using System;
using System.Collections.Generic;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PSingleton.DAOs;
using CenfoEats2._0.PSingleton.Mapper;

namespace CenfoEats2._0.PSingleton.CRUD
{
    public class OrderCrudFactory : CrudFactory
    {
        private OrderMapper _mapper;

        public OrderCrudFactory()
        {
            _mapper = new OrderMapper();
            dao = SqlDAO.GetInstance();
        }

        public override void Create(BaseEntity dto)
        {

            var order = (OrderDB)dto;
            var operation = _mapper.GetCreateStatement(order);

            dao.ExecuteProcedure(operation);


        }

        public override void Delete(int id)
        {
            try
            {
                // Implementa la lógica para eliminar un pedido por ID
                // Puedes utilizar el método GetDeleteStatement del mapper y ejecutar la operación con dao
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el pedido: {ex.Message}");
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            var listOrders = new List<T>();
            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_ORDERS_PR" };

            var listResults = dao.ExecuteQueryProcedure(sqlOperation);

            if (listResults.Count > 0)
            {
                foreach (var row in listResults)
                {
                    var pedido = new OrderDB()
                    {
                        id = (int)row[""],
                        pickUp = (int)row[""], //1 -> Pickup 0-> Recoger
                        idClient = (int)row[""],
                        idRestaurant = (int)row[""],
                        status = (string)row[""],
                        date = (DateTime)row[""],
                        idDriver = (int)row[""],
                        address = (string)row[""],

                    };
                    listOrders.Add((T)Convert.ChangeType(pedido, typeof(T)));

                }
            }
            return listOrders;
        }

        public override T RetrieveById<T>(int id)
        {
            try
            {
                // Implementa la lógica para recuperar un pedido por ID
                // Puedes utilizar el método GetRetrieveByIdStatement del mapper y ejecutar la operación con dao
                return default; // Cambia esto según la implementación real
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al recuperar el pedido por ID: {ex.Message}");
                return default;
            }
        }

        public override void Update(BaseEntity dto)
        {
            try
            {
                // Implementa la lógica para actualizar un pedido
                // Puedes utilizar el método GetUpdateStatement del mapper y ejecutar la operación con dao
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el pedido: {ex.Message}");
            }
        }
    }
}