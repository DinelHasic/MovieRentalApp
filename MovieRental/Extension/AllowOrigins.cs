namespace MovieRental.Extension
{
    public static class AllowOrigins
    {
        public static void AllowedOrigins(this IServiceCollection services,string[] allowedOrigins)
        {
            services.AddCors(option =>
            {
                option.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(allowedOrigins).
                    AllowAnyMethod().
                    AllowAnyHeader();
                });
            });
        }
    }
}
