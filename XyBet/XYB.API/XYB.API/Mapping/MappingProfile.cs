using AutoMapper;
using XYB.API.DTOs;
using XYB.Data.Entities;

namespace XYB.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Bet, BetViewModel>();
        }
    }
}
