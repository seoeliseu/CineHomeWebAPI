using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CineHome.Api.Infra.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        //Realizado a conecção com o banco de dados
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=dbCineHomeAPI;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
