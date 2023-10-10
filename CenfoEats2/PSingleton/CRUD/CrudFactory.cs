using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2.PSingleton.DAOs;

namespace CenfoEats2.PSingleton.CRUD
{
    public abstract class CrudFactory
    {
        protected SqlDAO dao;

        //Definicion de metodos obligatorios para los CRUD.
        public abstract void Create(BaseEntity dto);

        public abstract T RetrieveById<T>(int id);

        public abstract List<T> RetrieveAll<T>();

        public abstract void Update(BaseEntity dto);

        public abstract void Delete(int id);
    }
}
