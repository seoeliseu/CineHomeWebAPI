using AutoMapper;
using CineHome.Api.Domain.Dtos.Movie;
using CineHome.Api.Domain.Models;

namespace CineHome.Api.Infra.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<MovieModel, MovieDtoCreate>().ReverseMap();
            CreateMap<MovieModel, MovieDtoUpdate>().ReverseMap();
        }
    }
}
