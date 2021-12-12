using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface ITripServiceService
    {
        Task<IEnumerable<TripResponse>> GetAsync();
        Task<TripResponse> GetByIdAsync(int id);


    }
}
