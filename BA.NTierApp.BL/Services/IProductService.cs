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

        //product oluştururken
        //kendi içimde bir validasyon yapcam

        bool CreateProduct(Product product);

        //stok'daki seviye 0'altındaysa satma

        bool SellProduct(Product product);

        //
     
        List<Product> GetAllProduct(bool isExist = true);


    }
}
