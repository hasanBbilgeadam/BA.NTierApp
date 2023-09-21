using BA.NTierApp.DAL.Abstract;

namespace BA.NTierApp.DAL.Entities
{
    public class UserProductRecord:IEntity
    {
      
        public int Id { get; set; }


        public int ProductId { get; set; }
        public int UserID { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public User user { get; set; }

        public Product Product { get; set; }


    }
}
