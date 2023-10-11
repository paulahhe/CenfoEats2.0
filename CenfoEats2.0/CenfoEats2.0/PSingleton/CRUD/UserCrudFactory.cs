using System.Collections.Generic;
using System;
using CenfoEats2._0.PSingleton.Mapper;
using CenfoEats2._0.PSingleton.DAOs;
using CenfoEats2._0.PMetodoFabrica.Producto;
using CenfoEats2._0.PMetodoFabrica.ProductoConcreto;

namespace CenfoEats2._0.PSingleton.CRUD
{
    public class UserCrudFactory : CrudFactory
    {
        UserMapper _mapper;

        public UserCrudFactory()
        {
            _mapper = new UserMapper();
            dao = SqlDAO.GetInstance();
        }
        public override void Create(BaseEntity model)
        {
            var create = (Usuario)model;
            var sqlOperation = _mapper.GetCreateStatement(create);
            dao.ExecuteProcedure(sqlOperation);
        }
        public void CreateRepartidor(BaseEntity model)
        {
            var create = (Repartidor)model;
            var sqlOperation = _mapper.GetCreateStatement(create);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<UsuarioDB> RetrieveAll<UsuarioDB>()
        {
            var lstUsers = new List<UsuarioDB>();

            //Buscamos el statement para hacer un retrieve all
            var sqlOperation = _mapper.GetRetriveAllStatement();

            //Ejecutamos el retrieve all
            var lstResults = dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                var objsUsersOperation = _mapper.BuildObjects(lstResults);

                foreach (var op in objsUsersOperation)
                {
                    lstUsers.Add((UsuarioDB)Convert.ChangeType(op, typeof(UsuarioDB)));
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