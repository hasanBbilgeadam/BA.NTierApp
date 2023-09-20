using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Abstract;
using BA.NTierApp.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Managers
{
    public  abstract class BaseManager<T> : IService<T> where T : class, IEntity
    {
        GenericRepository<T> _repository;
        public BaseManager(GenericRepository<T> repository)
        {
            _repository = repository;
        }
        public void Add(T entity) => _repository.Add(entity);
        public void Delete(T entity) =>  _repository.Delete(entity);
        public List<T> GetAll(T entity) => _repository.GetAll();
        public T? GetById(int id) => _repository.Get(id);
        public void Update(T entity) => _repository.UpdateV2(entity); 
    }
}
