using System.Collections.Generic;

namespace Mvc_E_Commerce.Entity.Model
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
            Orders = new HashSet<Order>();
            WishList = new HashSet<WishList>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<WishList> WishList { get; set; }
    }
}