using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Abstract;
using BA.NTierApp.DAL.Context;
using BA.NTierApp.DAL.Entities;
using BA.NTierApp.DAL.Repository;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Managers
{
    public class ProductManger : GenericManager<Product>, IProductService
    {
        public ProductManger(IRepository<Product> repository) : base(repository)
        {
        }

        public void CustomProductSeriveMethod()
        {
            Console.WriteLine("boş");
        }
    }
}
