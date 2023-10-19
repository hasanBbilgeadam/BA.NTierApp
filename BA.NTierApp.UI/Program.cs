using BA.NTierApp.BL.Managers;
using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Context;
using BA.NTierApp.DAL.Entities;
using BA.NTierApp.DAL.Repository;
using System.Globalization;

namespace BA.NTierApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IProductService productService = new ProductManger(new GenericRepository<Product>(new AppDbContext()));

            productService.CustomProductSeriveMethod();
            productService.Delete(new());

        }
    }
}