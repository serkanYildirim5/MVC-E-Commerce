using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            ToTable("Categories");
            HasKey(x => x.CategoryId);
            Property(x => x.CategoryName).HasColumnType("varchar").HasMaxLength(250);
            //Self Join
            HasMany(x => x.SubCategories).WithOptional().HasForeignKey(g => g.ParentId);

        }
    }
}
