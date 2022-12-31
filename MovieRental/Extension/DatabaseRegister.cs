using Microsoft.EntityFrameworkCore;
using MovieRental.Options;
using MovieRental.Storage.Database;

namespace MovieRental.Extension
{
    internal static class DatabaseRegister
    {
        public static void RegisterDatabase(this IServiceCollection services, string connectionString,DatabaseOptions databaseOptions)
        {
            services.AddDbContext<MovieRentalDbContext>(option =>
               {
                  option.UseSqlServer(connectionString,sqlServeAction =>
                  {
                      sqlServeAction.EnableRetryOnFailure(databaseOptions.MaxRetryCount);

                      sqlServeAction.CommandTimeout(databaseOptions.TimeOut);
                  });

                  option.EnableDetailedErrors(databaseOptions.EnableDetailsError);
                  
                  option.EnableSensitiveDataLogging(databaseOptions.EnableSensetiveDataLogger);
               }
            );
        }
    }
}
