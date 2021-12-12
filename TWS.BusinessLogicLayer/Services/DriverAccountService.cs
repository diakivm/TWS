using AutoMapper;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Interfaces.Services;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.Interface.Repositories;

namespace TWS.BusinessLogicLayer.Services
{
    public class DriverAccountService : IDriverAccountService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IDriverAccountRepository driverAccountRepository;


        public async Task<IEnumerable<DriverAccountResponse>> GetAsync()
        {
            var driverAccounts = await driverAccountRepository.GetAsync();
            return driverAccounts?.Select(mapper.Map<DriverAccount, DriverAccountResponse>);
        }

        public async Task<DriverAccountResponse> GetByIdAsync(int id)
        {
            var driverAccount = await driverAccountRepository.GetByIdAsync(id);
            return mapper.Map<DriverAccount, DriverAccountResponse>(driverAccount);
        }


        public DriverAccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            driverAccountRepository = this.unitOfWork.DriverAccountRepository;
        }
    }
}
