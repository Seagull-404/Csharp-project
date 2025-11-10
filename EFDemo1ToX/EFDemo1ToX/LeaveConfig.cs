using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
    internal class LeaveConfig : IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.ToTable("T_Leaves");
            builder.HasOne<User>(l => l.Requester).WithMany().OnDelete(DeleteBehavior.Restrict).IsRequired();
            builder.HasOne<User>(l => l.Approver).WithMany();
        }
    }
}
