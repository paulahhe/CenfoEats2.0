using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PSingleton.DAOs
{
    public class SqlOperation
    {
        public string ProcedureName { get; set; }
        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<SqlParameter>();
        }
        public void AddVarcharParam(string paramName, string paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }
        public void AddIntParam(string paramName, int paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }

        public void AddDecimalParam(string paramName, decimal paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }

        public void AddTinyInyParam(string paramName, byte paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }
        public void AddDateParam(string paramName, DateTime paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }
    }
}
