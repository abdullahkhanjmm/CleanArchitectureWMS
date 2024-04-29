using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMS.Contracts.Warehouse;
using WMS.Domain.Warehouse;

namespace WMS.Infrastructure.Warehouse.Persistance
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<WareHouse>
    {
        public void Configure(EntityTypeBuilder<WareHouse> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedNever();
            builder.Property("_adminId").HasColumnName("AdminId");
            builder.Property(s => s.WareHousetype)
                .HasConversion(
                    warehouse => warehouse,
                    value => value
                );
        }
    }
}
