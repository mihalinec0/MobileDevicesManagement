using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileDevicesManagement.Data.DBSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileDevicesManagement.Data.EntityConfigurations
{
    public class MobileDeviceMakeEntityConfiguration : IEntityTypeConfiguration<MobileDeviceMake>
    {
        public void Configure(EntityTypeBuilder<MobileDeviceMake> builder)
        {
            builder.ToTable("MobileDeviceMake");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder.Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
