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
    class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.PlaceOfArrival)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(t => t.PlaceOfDeparture)
                    .HasMaxLength(100)
                    .IsRequired();

            builder.Property(t => t.TimeOfArrival)
                   .IsRequired();

            builder.Property(t => t.TimeOfDeparture)
                   .IsRequired();

            builder.Property(t => t.NumberOfFreeSeats)
                   .IsRequired();

            builder.HasOne(t => t.DriverAccount)
                   .WithMany(d => d.PublishedTrips)
                   .HasForeignKey(k => k.DriverAccountForeignKey);
             

            builder.HasOne(t => t.TravelerAccount)
                   .WithMany(d => d.PlannedTrips)
                   .HasForeignKey(k => k.TravelerAccountForeignKey);

            new TripSeeder().Seed(builder);
          
        }
    }
}
