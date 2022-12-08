using Microsoft.EntityFrameworkCore;
using MovieRental.Storage.Database;

namespace MovieRental.Extension
{
    internal static class DatabaseRegister
    {
        public static void RegisterDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MovieRentalDbContext>(option =>
               {
                  option.UseSqlServer(connectionString);
               }
            );
        }
    }
}
