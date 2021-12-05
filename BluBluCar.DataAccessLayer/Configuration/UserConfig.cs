using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TWS.DataAccessLayer.Configuration
{
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);                   

            builder.Property(u => u.FirstName)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(30);


            builder.Property(u => u.DateOfBirth)
                   .IsRequired();

            builder.Property(u => u.DateOfRegistration)
                   .HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Gender)
                   .HasDefaultValue("None")
                   .HasMaxLength(6);

            builder.Property(u => u.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(13);

            builder.HasOne(u => u.DriverAccount) //https://docs.microsoft.com/ru-ru/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
                   .WithOne(d => d.UserAccount)
                   .HasForeignKey<DriverAccount>(d => d.UserAccountForeignKey);

            builder.HasOne(u => u.TravelerAccount)
                   .WithOne(d => d.UserAccount)
                   .HasForeignKey<TravelerAccount>(d => d.UserAccountForeignKey);

            new UserSeeder().Seed(builder);
        }
    }
}
