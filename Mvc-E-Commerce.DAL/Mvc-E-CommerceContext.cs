using Mvc_E_Commerce.DAL.Mapping;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL
{
    public class Mvc_E_CommerceContext:DbContext
    {
        public Mvc_E_CommerceContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=MVC-E-CommerceDB;User Id=SA;Password = 123;MultipleActiveResultSets=true;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Advertising> Advertising { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<WishList> WishList { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new AdvertisingMapping());
            modelBuilder.Configurations.Add(new BasketMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new WishListMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
