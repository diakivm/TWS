using TWS.BusinessLogicLayer.DTO.Requests;
using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface IDriverAccountService
    {
        Task<IEnumerable<DriverAccountResponse>> GetAsync();
        Task<DriverAccountResponse> GetByIdAsync(int id);

        Task InsertAsync(DriverAccountRequest request);
        Task UpdateAsync(DriverAccountRequest request);
        Task DeleteAsync(int id);
    }
}
