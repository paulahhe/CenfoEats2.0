using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PSingleton.DAOs;

namespace CenfoEats2._0.PSingleton.Mapper
{
    internal interface ISqlStatements
    {
        SqlOperation GetCreateStatement(BaseEntity entity);
        SqlOperation GetRetriveStatement(BaseEntity entity);
        //SqlOperation GetRetriveByEmailStatement(string email);
        SqlOperation GetRetriveAllStatement();
        SqlOperation GetRetrieveByIdStatement(BaseEntity entity);
        SqlOperation GetUpdateStatement(BaseEntity entity);
        SqlOperation GetDeleteStatement(BaseEntity entity);
    }
}
