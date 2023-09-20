﻿using BA.NTierApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Services
{
    public interface IService<T> where T : class,IEntity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T? GetById(int id);
        List<T> GetAll(T entity);


    }
}
