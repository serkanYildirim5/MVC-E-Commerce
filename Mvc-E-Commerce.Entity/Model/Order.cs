using System;
using System.Collections.Generic;

namespace Mvc_E_Commerce.Entity.Model
{
    public class Order
    {
        public Order()
        {
            Products =new HashSet<Product>();
        }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status {get;set;}
        public double TotalPrice { get; set; } 
        public virtual ICollection<Product> Products { get; set; }
    }
}