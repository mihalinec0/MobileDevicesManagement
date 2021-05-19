using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileDevicesManagement.Data.DBSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileDevicesManagement.Data.EntityConfigurations
{
    public class MobileDeviceTypeEntityConfiguration : IEntityTypeConfiguration<MobileDeviceType>
    {
        public void Configure(EntityTypeBuilder<MobileDeviceType> builder)
        {
            builder.ToTable("MobileDeviceType");

            builder.HasKey(i => i.Id);
            builder.Property(id => id.Id).ValueGeneratedOnAdd();

            builder.Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
