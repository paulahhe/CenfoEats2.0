using System;
using System.Collections.Generic;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PSingleton.DAOs;

namespace CenfoEats2._0.PSingleton.Mapper
{
    public class ProductMapper : ISqlStatements, IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var platillo = new ProductsDB
            {
                id = (int)row["ID_PRODUCTS"],
                nombre = (string)row["NAME"],
                precio = (decimal)row["PRICE"],
                descripcion = (string)row["DESCRIPTION"]
            };
            return platillo;
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
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_PRODUCTS_PR" };

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