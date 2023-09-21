using BA.NTierApp.DAL.Abstract;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.DAL.Entities
{

    public  class User:IEntity
    {
        public User()
        {
            ProductRecords = new();
        }
        public int Id { get; set; }

        public string UserName { get; set; }

        public Gender Cinsiyet { get; set; }

        public List<UserProductRecord> ProductRecords { get; set; }
    }



    public enum Gender : int
    {
        erkek=1,
        kadın=2
    }
    public enum Status : int
    {
        free=0,
        outside=1,
        damaged=2
    }
}
