using BA.NTierApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Services
{
    public interface IGenericService<T> where T : class,IEntity
    {


        T Get(int id);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);


    }
}
