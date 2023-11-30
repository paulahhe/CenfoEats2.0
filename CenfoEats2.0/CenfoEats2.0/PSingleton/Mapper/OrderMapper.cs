using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using CenfoEats2._0.PSingleton.DAOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            return new SqlOperation { ProcedureName = "RET_ALL_ORDERS_PR" };
                        //id = (int)row["ID_ORDER"],
                        //pickUp = (int)row["PICK_UP"], //1 -> Pickup 0-> Recoger
                        //idClient = (int)row["ID_USER"],
                        //idRestaurant = (int)row["ID_RESTAURANT"],
                        //status = (string)row["STATUS"],
                        //date = (DateTime)row["ORDER_DATE"],
                        //idDriver = (int)row["ID_DRIVER"],
                        //address = (string)row["ADDRESS"],
        }
        public SqlOperation GetRetrieveAllPickUpOrders()
        {
            return new SqlOperation { ProcedureName = "RET_ALL_PICKUP_ORDERS_PR" };
        }
        public SqlOperation GetRetrieveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetrieveByIdADomicilioByID(int id)
        {
            var sqlOperation = new SqlOperation { ProcedureName = "RET_ADOMICILIO_BY_ID" };
            sqlOperation.AddIntParam("P_ID", id);
            return sqlOperation;
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