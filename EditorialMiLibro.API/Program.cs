using EditorialMiLibro.Application.Implementaciones;
using EditorialMiLibro.Application.Interfaces;
using EditorialMiLibro.Application.Profiles;
using EditorialMiLibro.Repository;
using EditorialMiLibro.Repository.Implementaciones;
using EditorialMiLibro.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(conf =>
                            conf.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IlibroApplication, Libroapplication>();
builder.Services.AddScoped<ILibroRepository, LibroRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
