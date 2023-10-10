using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CenfoEats2._0.PSingleton.DAOs
{
    public class SqlDAO
    {
        private string _connectionString = "";

        //Patron Singleton
        //Paso 1: Creamos instancia privada de la misma clase
        private static SqlDAO _instance;
        //Paso 2: constructor privado
        private SqlDAO()
        {
            //moverlo a jsonconfig.
            _connectionString = "Data Source=DESKTOP-3KB5PPJ;Initial Catalog=CenfoEatsDB;User ID=admin;Password=admin";
        }
        //Paso 3: metodo para exponer la instancia de la clase SqlDao.
        public static SqlDAO GetInstance()
        {
            //Paso 4: Validar el estado de la instancioa y asegurar que solo exista 1 
            if (_instance == null)
            {
                _instance = new SqlDAO();
            }
            return _instance;
        }
        //Metodo que sirve solo para enviar data a la BD pór medio de SP
        public void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        //Metodo que funciona para consultar informacion desde la base de datos, tambien permite el envio de data.
        public List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {

            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();

                //De aqui en adelante, trabaja en extraer la data de la consulta
                var reader = command.ExecuteReader();
                //Verifica que tenga filas o resultados la consulta realizada
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Construimos un diccionario segun cada una de las filas 
                        //retornadas por la consulta
                        var dictRow = new Dictionary<string, object>();

                        for (var index = 0; index < reader.FieldCount; index++)
                        {
                            //Agregamos cada una de las columnas al diccionario
                            //como una llave y un valor
                            var key = reader.GetName(index);
                            var value = reader.GetValue(index);

                            dictRow.Add(key, value);
                        }
                        //Guardamos en la lista, el diccionario que representa la fila de la consulta
                        lstResult.Add(dictRow);
                    }
                }
            }
            return lstResult;
        }
    }
}