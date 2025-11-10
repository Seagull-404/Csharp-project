using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
    internal class CommentConfig:IEntityTypeConfiguration<Comment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("T_Comments");
            builder.Property(c => c.Message).HasMaxLength(500).IsUnicode().IsRequired();
            builder.HasOne<Article>(c => c.TheArticle).WithMany(a => a.Comments).IsRequired();
        }
    }
   
    
}
