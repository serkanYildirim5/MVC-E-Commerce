using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
    public class WishListMapping : EntityTypeConfiguration<WishList>
    {
        public WishListMapping()
        {
            ToTable("WishList");
            HasKey(x=>x.WishListID);


            HasMany(k => k.Product).WithMany(u => u.WishList).Map(m =>
            {
                m.ToTable("WishList_Product_Table");
                m.MapLeftKey("WishListId");
                m.MapRightKey("ProductId");

            });
        }
    }
}
