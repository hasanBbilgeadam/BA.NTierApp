using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Managers
{
    public abstract class GenericManager<T>:IGenericService<T>  where T : class,IEntity
    {

        private IRepository<T> _repository;

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {

            
            _repository.Add(entity);


        }

        public void Delete(T entity)
        {
            _repository.Add(entity);
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
