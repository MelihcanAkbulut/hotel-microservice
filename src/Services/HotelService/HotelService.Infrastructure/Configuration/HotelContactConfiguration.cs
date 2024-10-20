using HotelService.Domain.Aggregate.HotelAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.Infrastructure.Configuration
{
    public class HotelContactConfiguration : IEntityTypeConfiguration<HotelContact>
    {
        public void Configure(EntityTypeBuilder<HotelContact> builder)
        {
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Information).IsRequired();
        }
    }
}
