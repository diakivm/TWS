using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Interface
{
    public interface ISeeder<T> where T : class
    {
        void Seed(EntityTypeBuilder<T> builder);

    }
}
