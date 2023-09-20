using BA.NTierApp.BL.Managers;
using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Entities;
using System.Globalization;

namespace BA.NTierApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DI 
            IProductService productService = new ProductManger();




            var data = productService.GetProductByID(1);


            var result = productService.SellProduct(data);

            if (result)
            {
                Console.WriteLine("işlem başarılı");
            }
            else { Console.WriteLine("işlem başarısız"); }
        }
    }
}