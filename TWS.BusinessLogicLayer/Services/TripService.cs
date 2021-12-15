using Aplication.DataAccess.Interface.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Requests;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Interfaces.Services;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.Parameters;

namespace TWS.BusinessLogicLayer.Services
{
    public class TripService : ITripService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly ITripRepository tripRepository;


        public async Task<IEnumerable<TripResponse>> GetAsync()
        {
            var trips = await tripRepository.GetAsync();
            return trips?.Select(mapper.Map<Trip, TripResponse>);
        }

        public async Task<IEnumerable<TripResponse>> GetAsync(TripParameters parameters)
        {
            var trips = await tripRepository.GetAsync(parameters);
            return trips?.Select(mapper.Map<Trip, TripResponse>);
        }

        public async Task<TripResponse> GetByIdAsync(int id)
        {
            var trip = await tripRepository.GetByIdAsync(id);
            return mapper.Map<Trip, TripResponse>(trip);
        }


        public async Task InsertAsync(TripRequest request)
        {
            var trip = mapper.Map<TripRequest, Trip>(request);
            await tripRepository.AddAsync(trip);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(TripRequest request)
        {
            var trip = mapper.Map<TripRequest, Trip>(request);
            await tripRepository.UpdateAsync(trip);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await tripRepository.DeleteAsync(id);
            await unitOfWork.SaveChangesAsync();
        }

        public TripService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            tripRepository = this.unitOfWork.TripsRepository;
        }


    }
}
