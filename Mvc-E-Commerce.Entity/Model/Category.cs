using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.Model
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SubCategories = new HashSet<Category>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
    }
}
