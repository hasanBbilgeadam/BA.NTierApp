using BA.NTierApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.DAL.Entities
{
    public class Product:IEntity
    {
        public Product()
        {
            UserRecord = new();
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public Status Status { get; set; }

        public Category Category { get; set; }

        public List<UserProductRecord> UserRecord { get; set; }




    }
}
