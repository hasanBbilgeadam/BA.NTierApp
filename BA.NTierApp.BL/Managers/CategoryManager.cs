using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Abstract;
using BA.NTierApp.DAL.Entities;
using BA.NTierApp.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Managers
{
    public class CategoryManager:BaseManager<Category>,ICategoryService
    {

        public CategoryManager(GenericRepository<Category> repository) : base(repository)
        {
            _repository = repository;
        }

        
    }
}
