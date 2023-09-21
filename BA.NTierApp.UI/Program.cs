using BA.NTierApp.BL.Managers;
using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Context;
using BA.NTierApp.DAL.Entities;
using BA.NTierApp.DAL.Repository;
using System.Globalization;
using System.Net.Http.Headers;

namespace BA.NTierApp.UI
{
    internal class Program
    {

        //uow

        static void Main(string[] args)
        {
            //DI 
            IProductService productService = new ProductManger( new GenericRepository<Product>(new AppDbContext()),new GenericRepository<User>(new AppDbContext()));


            //productService.LendTheProduct(1, 1);

            var result =  productService.WhoIsOwner(1);

            Console.WriteLine(result);





        }
    }
}