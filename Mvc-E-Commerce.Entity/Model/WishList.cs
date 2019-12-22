using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.Model
{
    public class WishList
    {
        public WishList()
        {
            Product = new HashSet<Product>();
        }
        public int WishListID { get; set; }

        public int UserID { get; set; }
        public int ProductID { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public bool IsActive
        {
            get; set;
        }
    }
}
