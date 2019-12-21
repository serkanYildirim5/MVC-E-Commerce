using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
    public class OrderMapping: EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            ToTable("Orders");
            HasKey(k=>k.OrderId);

            HasMany(k => k.Products).WithMany(u => u.Orders).Map(m=>
                {
                    m.ToTable("Order_Products_Table");
                    m.MapLeftKey("OrderId");
                    m.MapRightKey("PostId");

                });

        }
    }
}
