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
    class TravelerAccountConfig : IEntityTypeConfiguration<TravelerAccount>
    {
        public void Configure(EntityTypeBuilder<TravelerAccount> builder)
        {
            builder.HasKey(t => t.Id);

            new TravelerAccountSeeder().Seed(builder);
        }
    }
}
