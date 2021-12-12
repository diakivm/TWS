using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface IDriverAccountService
    {
        Task<IEnumerable<DriverAccountResponse>> GetAsync();
        Task<DriverAccountResponse> GetByIdAsync(int id);

    }
}
