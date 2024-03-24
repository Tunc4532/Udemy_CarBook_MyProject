using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.AboutHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.CatagoryHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers;
using Udemy_CarBook.Aplication.Features.RepositoryPattern;
using Udemy_CarBook.Aplication.Interfaces;
using Udemy_CarBook.Aplication.Interfaces.BlogInterfaces;
using Udemy_CarBook.Aplication.Interfaces.CarDescriptionInterfaces;
using Udemy_CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using Udemy_CarBook.Aplication.Interfaces.CarInterfaces;
using Udemy_CarBook.Aplication.Interfaces.CarPricingInterfaces;
using Udemy_CarBook.Aplication.Interfaces.RentACarInterfaces;
using Udemy_CarBook.Aplication.Interfaces.ReviewInterfaces;
using Udemy_CarBook.Aplication.Interfaces.StatisticsInterfaces;
using Udemy_CarBook.Aplication.Interfaces.TagCloudInterfaces;
using Udemy_CarBook.Aplication.Services;
using Udemy_CarBook.Aplication.Tools;
using Udemy_CarBook.Persistence.Context;
using Udemy_CarBook.Persistence.Repositories;
using Udemy_CarBook.Persistence.Repositories.BlogRepositories;
using Udemy_CarBook.Persistence.Repositories.CarDescriptionRepositories;
using Udemy_CarBook.Persistence.Repositories.CarFeatureRepositories;
using Udemy_CarBook.Persistence.Repositories.CarPricingRrepositories;
using Udemy_CarBook.Persistence.Repositories.CarRepositories;
using Udemy_CarBook.Persistence.Repositories.CommentRepositories;
using Udemy_CarBook.Persistence.Repositories.RentACarRepositories;
using Udemy_CarBook.Persistence.Repositories.ReviewRepositories;
using Udemy_CarBook.Persistence.Repositories.StatisticsRepositories;
using Udemy_CarBook.Persistence.Repositories.TagCloudRepositories;
using Udemy_CarBook.WebApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

#region MediatorRegistiritaions
// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepostory<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlokRepsitory), typeof(BlokRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepostory));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepositories));
builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarWithBrandQueryHandler>();

builder.Services.AddScoped<GetCatagoryQueryHandler>();
builder.Services.AddScoped<GetCatagoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCatagoryCommandHandler>();
builder.Services.AddScoped<UpdateCatagoryCommandHandler>();
builder.Services.AddScoped<RemoveCatagoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
#endregion


builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers().AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<CarHub>("/carhub");
app.Run();
