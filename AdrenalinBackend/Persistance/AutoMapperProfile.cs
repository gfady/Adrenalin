using AutoMapper;
using Domain.DTOs.Club;
using Domain.DTOs.New;
using Domain.DTOs.Promotion;
using Domain.DTOs.Visit;
using Domain.Models;

namespace Persistance
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Promotion, PromotionCreateDTO>().ReverseMap();
            CreateMap<Club, ClubCreateDTO>().ReverseMap();
            CreateMap<New, NewCreateDTO>().ReverseMap();
            CreateMap<Visit, VisitCreateDTO>().ReverseMap();
        }
    }
}
