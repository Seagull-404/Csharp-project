using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgTree
{
    internal class OragUnitConfig : IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.ToTable("T_OrgUnits");
            builder.Property(o => o.Name).HasMaxLength(50).IsUnicode().IsRequired();
            builder.HasOne<OrgUnit>(o => o.Parent).WithMany(o => o.Children).OnDelete(DeleteBehavior.Restrict);//根节点没有Parent，所以此属性不能为“IsRequired()”
        }
    }
}
