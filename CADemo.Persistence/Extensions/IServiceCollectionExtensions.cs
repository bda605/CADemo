using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemo.Application.Interface;
using CADemo.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CADemo.Persistence.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddPersistenceLayer(this IServiceCollection services)
        {
            //services.AddMappings();
            
            services.AddRepositories();
        }

        //private static void AddMappings(this IServiceCollection services)
        //{
        //    services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //}

        //public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        //{
        //    var connectionString = configuration.GetConnectionString("DefaultConnection");

        //    services.AddDbContext<ApplicationDbContext>(options =>
        //        options.UseSqlServer(connectionString,
        //            builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        //}

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
