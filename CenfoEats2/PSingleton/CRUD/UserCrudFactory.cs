using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2.PSingleton.DAOs;
using CenfoEats2.PSingleton.Mapper;

namespace CenfoEats2.PSingleton.CRUD
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
            var create = (User)model;
            var sqlOperation = _mapper.GetCreateStatement(create);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
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
