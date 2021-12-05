using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.DataAccessLayer.Configuration
{
    class TransportConfig : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CarBrand)
                   .HasMaxLength(50);

            builder.Property(c => c.CarModel)
                   .HasMaxLength(50);

            new TransportSeeder().Seed(builder);
        }
    }
}
