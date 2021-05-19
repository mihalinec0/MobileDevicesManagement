using MobileDevicesManagement.Data.DBSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MobileDevicesManagement.Data.EntityConfigurations
{
    public class MobileDeviceEntityConfiguration : IEntityTypeConfiguration<MobileDevice>
    {
        public void Configure(EntityTypeBuilder<MobileDevice> builder)
        {
            builder.ToTable("MobileDevices");
            builder.HasKey(id => id.Id);
            builder.Property(id => id.Id).ValueGeneratedOnAdd();


            builder.HasIndex(s => s.SerialNumber).IsUnique();  
            builder.HasIndex(i => i.IMEI).IsUnique();

            builder.Property(im => im.IMEI)
                .HasMaxLength(13)
                .IsRequired();
  
            builder.Property(se => se.SerialNumber)
                .HasMaxLength(12)
                .IsRequired();


            builder.HasOne(t => t.Type)
                .WithMany(m => m.MobileDevices)
                .IsRequired();

            builder.HasOne(mo => mo.Model)
                .WithMany(m => m.MobileDevices)
                .IsRequired();

            builder.HasOne(ma => ma.Make)
                .WithMany(m => m.MobileDevices)
                .IsRequired();

        }
    }
}
