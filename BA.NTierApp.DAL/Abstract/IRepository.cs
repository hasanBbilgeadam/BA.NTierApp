using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.DAL.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        T? Get(int id);
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity, T unchanged);
        void UpdateV2(T entity);
        IQueryable<T> GetQueryable();

    }
}
