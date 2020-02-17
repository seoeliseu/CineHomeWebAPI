using CineHome.Api.Domain.Entities;
using CineHome.Api.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ContextFake
{
    public class MyContextFake 
    {
        DbContextOptions<MyContext> options;
        public MyContextFake(string databaseName)
        {
            CarregarBancoDados(databaseName);
        }
        
        private void CarregarBancoDados(string databaseName)
        {
            options = new DbContextOptionsBuilder<MyContext>()
                        .UseInMemoryDatabase(databaseName: databaseName)
                        .Options;

            using (var context = new MyContext(options))
            {
                context.Movies.Add(new MovieEntity
                {
                    Id = new Guid("d736ef12-2726-440f-85b7-2ca0d4cea388"),
                    OriginalTitle = "Movie 1"
                    ,
                    ReleaseYear = 2018,
                    NationalTitle = "Coringa"
                });
                context.Movies.Add(new MovieEntity
                {
                    Id = Guid.NewGuid(),
                    OriginalTitle = "Movie 2"
                    ,
                    ReleaseYear = 2018,
                    NationalTitle = "Action"
                });
                context.Movies.Add(new MovieEntity
                {
                    Id = Guid.NewGuid(),
                    OriginalTitle = "Movie 3"
                    ,
                    ReleaseYear = 2019,
                    NationalTitle = "Action"
                });
                context.SaveChanges();
            }
        }

        public MyContext context()
        {
            return new MyContext(options);
        }


    }
}
