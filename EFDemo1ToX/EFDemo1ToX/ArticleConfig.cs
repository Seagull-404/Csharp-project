using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
    internal class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
           builder.ToTable("T_Articles");
            builder.Property(a=>a.Title).HasMaxLength(100).IsUnicode().IsRequired();
            builder.Property(a => a.Message).IsUnicode().IsRequired();
        }
    }


}
