using AutoMapper;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Interfaces.Services;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.Interface.Repositories;

namespace TWS.BusinessLogicLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IUserRepository userRepository;


        public async Task<IEnumerable<UserResponse>> GetAsync()
        {
            var users = await userRepository.GetAsync();
            return users?.Select(mapper.Map<User, UserResponse>);
        }

        public async Task<UserResponse> GetByIdAsync(int id)
        {
            var user = await userRepository.GetByIdAsync(id);
            return mapper.Map<User, UserResponse>(user);
        }

        public async Task InsertAsync(UserRequest request)
        {
            var user = mapper.Map<UserRequest, User>(request);
            await userRepository.AddAsync(user);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserRequest request)
        {
            var user = mapper.Map<UserRequest, User>(request);
            await userRepository.UpdateAsync(user);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await userRepository.DeleteAsync(id);
            await unitOfWork.SaveChangesAsync();
        }

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            userRepository = this.unitOfWork.UserRepository;
        }
    }
}
