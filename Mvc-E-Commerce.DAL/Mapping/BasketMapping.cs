using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
   public class BasketMapping : EntityTypeConfiguration<Basket>
    {
        public BasketMapping()
        {
            ToTable("Baskets");
            HasKey(x=>x.BasketId);
        }
    }
}
