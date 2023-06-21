namespace WalmartApi.DAL
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using WalmartApi.Models;

    public class DALDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DALDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("connectionstring");
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Agrega tus DbSet y configuraciones aquí
        public DbSet<User> Users { get; set; }
    }
}

   


