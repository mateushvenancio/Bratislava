using BratislavaApi.Core.Middlewares;
using BratislavaApi.DbContexts;
using BratislavaApi.Repositories;
using BratislavaApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PostgresDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"))
);
builder.Services.AddScoped<ICategoriesRepository, CategoriesService>();
builder.Services.AddScoped<IProductRepository, ProductsService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<GlobalErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
