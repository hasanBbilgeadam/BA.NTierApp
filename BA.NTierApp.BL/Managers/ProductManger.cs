﻿using BA.NTierApp.BL.Services;
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
    public class ProductManger : IProductService
    {

        GenericRepository<Product> repository;
        public ProductManger()
        {
            repository = new(new AppDbContext());
        }
        public bool CreateProduct(Product product)
        {
            //validation
            //if


            repository.Add(product);
            return true;

            
        }

        public List<Product> GetAllProduct(bool isExist = true)
        {
                return isExist ? 
                repository.GetQueryable().Where(x => x.Stock > 0).ToList() 
                :repository.GetAll();
        }

        public Product? GetProductByID(int id)
             => repository.Get(id);

        public bool SellProduct(Product product)
        {
            var data = repository.Get(product.Id);

            if (data.Stock <= 0)
            {
                return false;
            }

            --data.Stock;
            repository.UpdateV2(data);
            return true;    
        }
    }
}