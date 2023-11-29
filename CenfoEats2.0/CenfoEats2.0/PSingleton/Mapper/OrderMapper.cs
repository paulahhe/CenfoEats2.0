using System;
using System.Collections.Generic;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PSingleton.DAOs;

namespace CenfoEats2._0.PSingleton.Mapper
{
    public class OrderMapper : ISqlStatements, IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var pedido = new OrderDB
            {
                id = (int)row["ID_ORDER"],
                pickUp = (int)row["PICK_UP"],
                idClient = (int)row["ID_USER"],
                idRestaurant = (int)row["ID_RESTAURANT"],
                status = (string)row["STATUS"],
                date = (DateTime)row["ORDER_DATE"],
                idDriver = (int)row["ID_DRIVER"],
                address = (string)row["ADDRESS"]
            };
            return pedido;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var user = BuildObject(row);
                lstResults.Add(user);
            }
            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var pedido = (OrderDB)entity;
            var sqlOperation = new SqlOperation { ProcedureName = "CRE_ORDER" };


            sqlOperation.AddIntParam("ID_USER", pedido.idClient);
            sqlOperation.AddIntParam("ID_RESTAURANT", pedido.idRestaurant);
            sqlOperation.AddVarcharParam("STATUS", pedido.status);
            sqlOperation.AddDateParam("ORDER_DATE", pedido.date);
            sqlOperation.AddIntParam("PICK_UP", pedido.pickUp);
            sqlOperation.AddIntParam("ID_RESTAURANT", pedido.idDriver);
            sqlOperation.AddVarcharParam("ADDRESS", pedido.address);

            return sqlOperation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var sqlOperation = new SqlOperation();

            return sqlOperation;
        }

        public SqlOperation GetRetrieveByIdStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}