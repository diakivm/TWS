using TWS.BusinessLogicLayer.DTO.Requests;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.DataAccessLayer.Parameters;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface ITripService
    {
        Task<IEnumerable<TripResponse>> GetAsync();
        Task<IEnumerable<TripResponse>> GetAsync(TripParameters parameters);
        Task<TripResponse> GetByIdAsync(int id);

        Task InsertAsync(TripRequest request);
        Task UpdateAsync(TripRequest request);
        Task DeleteAsync(int id);
    }
}
