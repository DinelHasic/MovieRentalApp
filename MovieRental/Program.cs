using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MovieRental.Contract;
using MovieRental.Domain.Repository;
using MovieRental.Extension;
using MovieRental.Services;
using MovieRental.Shered;
using MovieRental.Storage.Database;
using MovieRental.Storage.Repositorys;
using MovieRental.Storage.UnitOfWork;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("Database");

string[] allowedOrigins = builder.Configuration.GetSection("AllowOrigin").Get<string[]>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddScoped<IUserServices, UserServices>()
                .AddScoped<IMovieServices, MovieServices>()
                .AddScoped<IDirectorServices, DirectorsServices>()
                .AddScoped<IGenreServices, GenreServices>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IMovieRepository, MovieRepository>() 
                .AddScoped<IDirectorRepository, DirectorRepository>()
                .AddScoped<IGenreRepository, GenreRepository>()
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IMovieRentalDbContext, MovieRentalDbContext>()
                .AddSwaggerGen().RegisterDatabase(connectionString);



builder.Services.AllowedOrigins(allowedOrigins);


var appConfig = builder.Configuration.GetSection("Auth");


builder.Services.Configure<Auth>(appConfig);

var auth = appConfig.Get<Auth>();

var secret = Encoding.ASCII.GetBytes(auth.Key!);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(secret)
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
