using AutoMapper;
using CineHome.Api.Application.Controllers;
using CineHome.Api.Domain.Dtos.Movie;
using CineHome.Api.Domain.Entities;
using CineHome.Api.Domain.Interfaces;
using CineHome.Api.Infra.Data.Context;
using CineHome.Api.Infra.Data.Repository;
using CineHome.Api.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Test.ContextFake;
using Xunit;

namespace CineHome.Api.Test
{
    public class MovieControllerTest
    {
        [Fact]
        public void ShouldGetMovie()
        {
            var _repository = new Mock<IRepository<MovieEntity>>();
            //var _repository = new BaseRepository<MovieEntity>();
            var _mapper = new Mock<IMapper>();

            //var _service = new Mock<MovieService>(_repository.Object, _mapper.Object);
            var _service = new MovieService(_repository.Object, _mapper.Object);

            var _controller = new MoviesController(_service);
            var result = _controller.Get(new Guid("d736ef12-2726-440f-85b7-2ca0d4cea385"));

            var resultOK = result.Result as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(200, resultOK.StatusCode);
        }

        [Fact]
        public async void ShouldGetNullById()
        {
            var db = new MyContextFake("Teste2");
            BaseRepository<MovieEntity> movieRepository = new BaseRepository<MovieEntity>(db.context());
                var movie = await movieRepository.SelectAsync(new Guid("d736ef12-2726-440f-85b7-2ca0d4cea386"));
                Assert.Null(movie);
        }

        [Fact]
        public async void ShouldGetMovielById()
        {
            var db = new MyContextFake("Teste3");
            BaseRepository<MovieEntity> movieRepository = new BaseRepository<MovieEntity>(db.context());
            var movie = await movieRepository.SelectAsync(new Guid("d736ef12-2726-440f-85b7-2ca0d4cea388"));
            Assert.Equal("Coringa",movie.NationalTitle);
        }
    }
}
