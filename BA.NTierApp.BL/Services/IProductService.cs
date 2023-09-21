using BA.NTierApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Services
{
    public interface IProductService:IService<Product>
    {
        bool CreateProduct(Product product);
        bool SellProduct(Product product);
        List<Product> GetAllProduct(bool isExist = true);

        bool LendTheProduct(int product, int user);

        string WhoIsOwner(int id);

    }
}
