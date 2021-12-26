using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponse>> GetAsync();
        Task<UserResponse> GetByIdAsync(int id);

        Task InsertAsync(UserRequest request);
        Task UpdateAsync(UserRequest request);
        Task DeleteAsync(int id);
    }
}
