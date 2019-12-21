using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
    public class AdvertisingMapping : EntityTypeConfiguration<Advertising>
    {
        public AdvertisingMapping()
        {
            ToTable("Advertising");
            HasKey(x => x.AdvertisingId);
            Property(x => x.Path).HasColumnType("varchar").HasMaxLength(500);
        }

    }
}
