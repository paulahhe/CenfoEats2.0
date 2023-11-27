using System;
using System.Collections.Generic;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PSingleton.DAOs;

namespace CenfoEats2._0.PSingleton.Mapper
{
    public class UserMapper : ISqlStatements, IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var user = new UsuarioDB
            {
                id = (int)row["ID_USER"],
                nombre = (string)row["NAME"],
                correo_electronico = (string)row["EMAIL"],
                telefono = (string)row["PHONE_NUMBER"],
                tipo = (string)row["ACCOUNT_TYPE"],
            };
            return user;
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
            /*CREATE PROCEDURE [dbo].[CRE_USER_PR]
                  @P_Name nvarchar(50),
                  @P_Email nvarchar(50),
                  @P_PhoneNumber nvarchar(50),
                  @P_AccountType nvarchar(50)
              AS
              BEGIN
                  SET NOCOUNT ON;

                  INSERT INTO [dbo].[TBL_USER] (NAME, EMAIL, PHONE_NUMBER, ACCOUNT_TYPE)
                  VALUES (@P_Name, @P_Email, @P_PhoneNumber, @P_AccountType);
              END;*/

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_USER_PR" };
            var user = (Usuario)entity;
            sqlOperation.AddVarcharParam("P_Name", user.nombre);
            sqlOperation.AddVarcharParam("P_Email", user.correo_electronico);
            sqlOperation.AddVarcharParam("P_PhoneNumber", user.nombre);
            sqlOperation.AddVarcharParam("P_AccountType", user.tipo);
            return sqlOperation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_USER_PR" };

            return sqlOperation;
        }

        public SqlOperation GetRandomRepartidorStatement()
        {
            var sqlOperation = new SqlOperation { ProcedureName = "RET_RANDOM_REPARTIDOR_USER_PR" };
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
