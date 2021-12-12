using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.Interfaces.Services
{
    public interface ITravelerAccountService
    {
        Task<IEnumerable<TravelerAccountResponse>> GetAsync();
        Task<TravelerAccountResponse> GetByIdAsync(int id);
    }
}
