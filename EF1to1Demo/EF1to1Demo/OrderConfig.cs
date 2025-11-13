using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1to1Demo
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("T_Orders");
            builder.HasOne(o => o.Delivery)
                   .WithOne(d => d.Order)
                   .HasForeignKey<Delivery>(d => d.OrderId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
