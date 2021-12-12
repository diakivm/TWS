using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void CreateUserMaps()
        {
            CreateMap<User, UserResponse>();
        }

        private void CreateTransportMaps()
        {
            CreateMap<Transport, TransportResponse>();
        }

        private void CreateDriverAccountMaps()
        {
            CreateMap<DriverAccount, DriverAccountResponse>();
        }

        private void CreateTravelerAccountMaps()
        {
            CreateMap<TravelerAccount, TravelerAccountResponse>();
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
