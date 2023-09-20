using BA.NTierApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.DAL.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; } 
    }
}
