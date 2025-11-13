using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1to1Demo
{
    internal class DeliveryConfig : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
           builder.ToTable("T_Deliveries");
            builder.Property(d => d.CompanyName).IsUnicode().HasMaxLength(10);
            builder.Property(d => d.Number).HasMaxLength(50);
        }
    }
}
