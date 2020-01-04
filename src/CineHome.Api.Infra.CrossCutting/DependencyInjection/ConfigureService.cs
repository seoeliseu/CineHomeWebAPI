using CineHome.Api.Domain.Interfaces.Services.Movie;
using CineHome.Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CineHome.Api.Infra.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMovieService, MovieService>();
        }
    }
}
