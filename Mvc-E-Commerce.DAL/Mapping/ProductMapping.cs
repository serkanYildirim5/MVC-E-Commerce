using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
   public  class ProductMapping: EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("Products");
            HasKey(x=>x.ProductId);
            Property(x => x.ProductName).HasColumnType("varchar").HasMaxLength(250);
            Property(x => x.Brand).HasColumnType("varchar").HasMaxLength(250);
            Property(x => x.Model).HasColumnType("varchar").HasMaxLength(250);
            Property(x => x.Description).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Picture).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
