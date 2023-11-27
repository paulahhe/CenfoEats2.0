using System.Collections.Generic;
using System;
using CenfoEats2._0.PSingleton.Mapper;
using CenfoEats2._0.PSingleton.DAOs;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;
using CenfoEats2._0.ObjetosDB;

namespace CenfoEats2._0.PSingleton.CRUD
{
    public class OrderCrudFactory : CrudFactory
    {
        OrderMapper _mapper;

        public OrderCrudFactory()
        {
            _mapper = new OrderMapper();
            dao = SqlDAO.GetInstance();
        }
        public override void Create(BaseEntity dto)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public List<OrderDB> RetrieveAllOrders<T>()
        {
            var lstOrders = new List<OrderDB>();

            //Buscamos el statement para hacer un retrieve all
            var sqlOperation = _mapper.GetRetriveAllStatement();

            //Ejecutamos el retrieve all
            var lstResults = dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                var objsUsersOperation = _mapper.BuildObjects(lstResults);

                foreach (var op in objsUsersOperation)
                {
                    lstUsers.Add((ProductsDB)Convert.ChangeType(op, typeof(ProductsDB)));
                }
            }
            return lstUsers;
        }

        public override T RetrieveById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(BaseEntity dto)
        {
            throw new NotImplementedException();
        }
    }
}