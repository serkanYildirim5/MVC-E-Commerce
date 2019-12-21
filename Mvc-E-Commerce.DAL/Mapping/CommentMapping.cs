using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Mapping
{
    public class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            ToTable("Comments");
            HasKey(x => x.CommentId);
            Property(x => x.CommentTitle).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.CommentContent).HasColumnType("varchar").HasMaxLength(350);
            Property(x => x.FullName).HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.Mail).HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.CreateDate).HasColumnType("date");
        }
    }
}
