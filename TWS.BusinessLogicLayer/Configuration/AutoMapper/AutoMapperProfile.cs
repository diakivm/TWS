using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Requests;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.DataAccessLayer.Entities;

namespace TWS.BusinessLogicLayer.Configuration
{
    public class AutoMapperProfile : Profile
    {

        private readonly IServiceCollection asd;

        private void CreateTripMaps()
        {
            CreateMap<Trip, TripResponse>();
            CreateMap<TripRequest, Trip>();
        }

        private void CreateUserMaps()
        {
            CreateMap<User, UserResponse>();
            CreateMap<UserRequest, User>();
        }

        private void CreateTransportMaps()
        {
            CreateMap<Transport, TransportResponse>();
            CreateMap<TransportRequest, Transport>();
        }

        private void CreateDriverAccountMaps()
        {
            CreateMap<DriverAccount, DriverAccountResponse>();
            CreateMap<DriverAccountRequest, DriverAccount>();
        }

        private void CreateTravelerAccountMaps()
        {
            CreateMap<TravelerAccount, TravelerAccountResponse>();
            CreateMap<TravelerAccountRequest, TravelerAccount>();
        }


        public AutoMapperProfile()
        {
            CreateUserMaps();
            CreateDriverAccountMaps();
            CreateTravelerAccountMaps();
            CreateTripMaps();
            CreateTransportMaps();
        }

    }
}
