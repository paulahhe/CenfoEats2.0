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
            var messagesList = new List<T>();
            var sqlOperation = _mapper.GetRetriveAllStatement();
            var resultsList = dao.ExecuteQueryProcedure(sqlOperation);

            if (resultsList.Count > 0)
            {
                var objects = _mapper.BuildObjects(resultsList);
                foreach (var obj in objects)
                {
                    messagesList.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return messagesList;
        }

        public List<T> RetrieveAllPickUpOrders<T>()
        {
            var mLists = new List<T>();
            var sqlOp = _mapper.GetRetrieveAllPickUpOrders();
            var listResults = dao.ExecuteQueryProcedure(sqlOp);
            if (listResults.Count > 0)
            {
                var objects = _mapper.BuildObjects(listResults);
                foreach (var obj in objects)
                {
                    mLists.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return mLists;
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
        public T RetrieveByIdADomicilio<T>(int id)
        {
            var sqlOperation = _mapper.GetRetrieveByIdADomicilioByID(id);
            var result = dao.ExecuteQueryProcedure(sqlOperation);

            if (result.Count > 0)
            {
                var obj = _mapper.BuildObject(result[0]);
                return (T)Convert.ChangeType(obj, typeof(T));
            }
            return default(T);
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