using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PSingleton.DAOs;

namespace CenfoEats2._0.PSingleton.Mapper
{
    public class UserMapper : ISqlStatements, IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var user = new User
            {
                Id = (int)row["ID_USER"],
                Name = (string)row["NAME"],
                Email = (string)row["EMAIL"],
                Password = (string)row["PASSWORD"],
                RegisteredAt = (DateTime)row["REGISTERED_AT"],
                AccountStatus = (int)row["ACCOUNT_STATUS"],
                PhoneNumber = (string)row["PHONE_NUMBER"],
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
            var sqlOperation = new SqlOperation { ProcedureName = "CRE_USER_PR" };

            var user = (User)entity;

            sqlOperation.AddVarcharParam("P_Name", user.Name);
            sqlOperation.AddVarcharParam("P_Email", user.Email);
            sqlOperation.AddVarcharParam("P_PasswordHash", user.Password);
            sqlOperation.AddDateParam("P_RegisteredAt", user.RegisteredAt);
            sqlOperation.AddIntParam("P_AccountStatus", user.AccountStatus);
            sqlOperation.AddVarcharParam("P_PhoneNumber", user.PhoneNumber);

            return sqlOperation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new NotImplementedException();
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
