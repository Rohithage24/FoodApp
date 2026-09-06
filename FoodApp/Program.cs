using Microsoft.EntityFrameworkCore;
using FoodApp.Data;
using FoodApp.Repositories.Interfaces;
using FoodApp.Repositories.Implementations;
using FoodApp.Services.Interfaces;
using FoodApp.Services.Implementations;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<FoodAppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodDBConnect")));

// Register the repository and service interfaces and their implementations
builder.Services.AddScoped<IMasterRoleRepository, MasterRoleRepository>();
builder.Services.AddScoped<IMasterRoleServices, MasterRoleServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelServices, HotelServices>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapGet("/", () =>
{
    return Results.Ok("Welcome to the FoodApp API!");
});
app.UseHttpsRedirection();

app.MapControllers();

app.Run();


