using Aplication.DataAccess.Interface.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Interfaces.Services;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.Interface.Repositories;

namespace TWS.BusinessLogicLayer.Services
{
    public class TravelerAccountService : ITravelerAccountService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly ITravelerAccountRepository travelerAccountRepository;


        public async Task<IEnumerable<TravelerAccountResponse>> GetAsync()
        {
            var travelerAccounts = await travelerAccountRepository.GetAsync();
            return travelerAccounts?.Select(mapper.Map<TravelerAccount, TravelerAccountResponse>);
        }

        public async Task<TravelerAccountResponse> GetByIdAsync(int id)
        {
            var travelerAccount = await travelerAccountRepository.GetByIdAsync(id);
            return mapper.Map<TravelerAccount, TravelerAccountResponse>(travelerAccount);
        }

        public async Task InsertAsync(TravelerAccountRequest request)
        {
            var travelerAccount = mapper.Map<TravelerAccountRequest, TravelerAccount>(request);
            await travelerAccountRepository.AddAsync(travelerAccount);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(TravelerAccountRequest request)
        {
            var travelerAccount = mapper.Map<TravelerAccountRequest, TravelerAccount>(request);
            await travelerAccountRepository.UpdateAsync(travelerAccount);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await travelerAccountRepository.DeleteAsync(id);
            await unitOfWork.SaveChangesAsync();
        }

        public TravelerAccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            travelerAccountRepository = this.unitOfWork.TravelerAccountRepository;

        }
    }
}
