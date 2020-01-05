using AutoMapper;
using CineHome.Api.Domain.Dtos.Movie;
using CineHome.Api.Domain.Entities;

namespace CineHome.Api.Infra.CrossCutting.Mappings
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<MovieEntity, MovieDtoCreate>().ReverseMap();
            CreateMap<MovieEntity, MovieDtoUpdate>().ReverseMap();
            CreateMap<MovieEntity, MovieDtoResult>().ReverseMap();
        }
    }
}
