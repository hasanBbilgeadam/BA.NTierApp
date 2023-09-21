using BA.NTierApp.BL.Services;
using BA.NTierApp.DAL.Context;
using BA.NTierApp.DAL.Entities;
using BA.NTierApp.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.BL.Managers
{
    public class ProductManger : BaseManager<Product>,IProductService
    {
        GenericRepository<User> _userRepository;
        GenericRepository<UserProductRecord> _userProductRepo;
        public ProductManger(GenericRepository<Product> repository, GenericRepository<User> userRepo ):base(repository)
        {
            _repository = repository;
            _userRepository = userRepo;
           
        }
        public bool CreateProduct(Product product)
        {
            //validation
            //if

            _repository.Add(product);
            return true;
            
        }
        public List<Product> GetAllProduct(bool isExist = true)
        {
                return isExist ?
                _repository.GetQueryable().Where(x => x.Stock > 0).ToList() 
                : _repository.GetAll();
        }
        public bool LendTheProduct(int product, int user)
        {
            //ürünün statusu free mi ?

            var data = _repository.Get(product);

            if (data != null)
            {
                if (data.Status == Status.free)
                {
                     var userdata = _userRepository.Get(user);
                    if (userdata == null)
                    {
                        return false;
                    }
                    data.UserRecord.Add(new UserProductRecord()
                    {
                        user = userdata,
                        TakenDate = DateTime.Now,

                    });
                    data.Status = Status.outside;


                    _repository.UpdateV2(data);
                    return true;    

                }

            }


            return false;
        }
        public bool SellProduct(Product product)
        {
            var data = _repository.Get(product.Id);

            if (data.Stock <= 0)
            {
                return false;
            }

            --data.Stock;
            _repository.UpdateV2(data);
            return true;    
        }
        public string WhoIsOwner(int id)
        {
            
            var ürün =  _repository
                .GetQueryable()
                .Include(x=>x.UserRecord.Where(x=>x.ReturnDate == null))
                .ThenInclude(x=>x.user)
                .Where(x=>x.Id == id)
                .First();

            if (ürün == null)
                return "ürün bulunamadı ";
            if (ürün.Status == Status.free)
                return "ürünün sahibi yok";
            var up = ürün.UserRecord.Where(x => x.ReturnDate == null).First();
                        return up.user.UserName + " "+ up.TakenDate.ToString();
            

            
        }
        public void ListToProductWithOwners()
        {
            var ürünler = _repository.GetQueryable().Include(x => x.UserRecord.Where(x=>x.ReturnDate == null)).ThenInclude(x => x.user).Where(x => x.Status == Status.outside).ToList();

            foreach (var item in ürünler)
            {
                Console.WriteLine(item.Id+" "+ item.Description+ " " + item.UserRecord[0].user.UserName);
            }
        }

        public void ProductReturn(int id)
        {
            //hali hazırda idade boşta olan biri bana göndermiş

            //gelen ürünün statusu outside

            var data = _repository.GetQueryable().Include(x=>x.UserRecord.Where(x=>x.ReturnDate == null)).Where(x=>x.Id == id).First();

            if (data.Status == Status.outside)
            {
                //free
                //user recodrs = bu ürünü bulup returndate kısmını doldurmam

                data.Status = Status.free;

                data.UserRecord[0].ReturnDate = DateTime.Now;


                _repository.UpdateV2(data);


                Console.WriteLine("işlem başarılı");
                return;
            }

            Console.WriteLine("hata");


        }

    }
}

//db'ye girip 
//category 
//product eklyin   =>3
//user ekleyin => 3 
//lendTheProduct => 3 kişi 1 er adet ürün verin

//hangi ürün kimde bunun bilgisini dönderen methoh => product manager 1

//usermanager yazınd
//=> bunun içerisinde de o kişinin aktif olarak sahip olduğu
//ürünlerin lisetesini getirin 2 (user id parametre geçerek)


//geçmişten bugüne kişinin almış olduğu ürünlerin listesi (user id parametre geçerek)
//bu da usermanager içerisinde kodlanacak 

