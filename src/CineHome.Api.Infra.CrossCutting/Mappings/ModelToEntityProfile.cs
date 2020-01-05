using AutoMapper;
using CineHome.Api.Domain.Entities;
using CineHome.Api.Domain.Models;

namespace CineHome.Api.Infra.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<MovieModel, MovieEntity>().ReverseMap();
        }
    }
}
