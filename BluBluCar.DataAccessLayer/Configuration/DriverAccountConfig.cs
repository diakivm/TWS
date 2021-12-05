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
    class DriverAccountConfig : IEntityTypeConfiguration<DriverAccount>
    {
        public void Configure(EntityTypeBuilder<DriverAccount> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.Transport)
                   .WithOne(c => c.DriverAccount)
                   .HasForeignKey<Transport>(d => d.DriverAccountForeignKey);

            new DriverAccountSeeder().Seed(builder);
        }
    }
}
