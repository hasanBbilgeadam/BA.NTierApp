using BA.NTierApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.NTierApp.DAL.Context
{
    public class AppDbContext:DbContext
    {



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //hardcode
            //json => appsetting.json app.xml abc.txt

            optionsBuilder.UseSqlServer(@"Data Source=ANK3-YZLMORT-08\SQLEXPRESS01;Initial Catalog=NTierApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                 .HasKey(x => x.Id);



            modelBuilder.Entity<Product>()
                .Property(x => x.Price)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Product>()
                .Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();

                

        }

    }
}
