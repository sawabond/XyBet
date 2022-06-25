using AutoMapper;
using XYB.API.DTOs;
using XYB.API.DTOs.User;
using XYB.Data.Entities;

namespace XYB.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Bet
            CreateMap<Bet, BetViewModel>();

            // AppUser
            CreateMap<AppUser, UserViewModel>();
            CreateMap<UserCreateModel, AppUser>();
        }
    }
}
