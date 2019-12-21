using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.Model
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public double Quantity { get; set; }
    }
}
