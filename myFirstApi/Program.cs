using Microsoft.EntityFrameworkCore;
using myFirstApi.BLL;
using myFirstApi.BLL.Mapper;
using myFirstApi.DAL;
using myFirstApi.DAL.Repositories;
using myFirstApi.DAL.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("myFirstApi"));
});
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
//Register Repository
builder.Services.AddScoped<IUserRepository, UserRepository>();
//Register services
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
